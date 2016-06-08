using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net;

namespace Editor
{
    public partial class New : Form
    {
        public New()
        {
            InitializeComponent();
        }

        private void company_SelectedIndexChange(object sender, EventArgs e)
        {
            try
            {
                getCompany();
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "ERROR!!");
            }
        }
        
        public void getCompany()
        {
            Uri serviceUrl = getserviceUrl();
            company.Items.Clear();
            company.Text = string.Empty;
            if (!blankcheck())
            {
                const string getNavCompany =
                        @"<soapenv:Envelope xmlns:soapenv='http://schemas.xmlsoap.org/soap/envelope/' " +
                                "xmlns:sys='urn:microsoft-dynamics-schemas/nav/system/'>" +
                                "<soapenv:Header/>" +
                                "<soapenv:Body>" +
                                    "<sys:Companies/>" +
                                "</soapenv:Body>" +
                         "</soapenv:Envelope>";

                string namespacestring = @"urn:microsoft-dynamics-schemas/nav/system/";
                XNamespace nsSys = namespacestring;
                string soapAction = string.Format("{0}:{1}", namespacestring, "Companies");
                var client = new WebClient
                {
                    Headers = new WebHeaderCollection
                        {
                            {"Content-Type", "text/xml; charset=utf-8"},
                            {"SOAPAction", soapAction}
                        },
                    Credentials = new NetworkCredential(userName.Text, password.Text)
                };

                var responsestring = client.UploadString(serviceUrl.ToString(), getNavCompany);
                XElement result = XElement.Parse(responsestring);
                if (result.Descendants(nsSys + "return_value").Any())
                {
                    foreach (var Company in result.Descendants(nsSys + "return_value"))
                    {
                        var count = 0;
                        company.Items.Add(Company.Value);
                    }

                }
            }
        }

        public Uri getserviceUrl()
        {
            var uri = new UriBuilder();
            uri.Host = serverName.Text;
            uri.Port = Convert.ToInt32(soapPort.Text);
            uri.Scheme = Uri.UriSchemeHttp;
            string strPath = string.Format("/{0}/WS/{1}", instanceName.Text, "SystemService");
            uri.Path = strPath;
            return uri.Uri;
        }

        public bool blankcheck()
        {
            if (string.IsNullOrEmpty(serverName.Text) || string.IsNullOrEmpty(userName.Text) ||
                string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(instanceName.Text) ||
                string.IsNullOrEmpty(soapPort.Text))
            {
                MessageBox.Show("Please Fill All Values", "ERROR!!");
                return true;
            }
            return false;
        }
    }
}
