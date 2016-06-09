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
using Request;
using Services;
using System.Xml;

namespace Editor
{
    public partial class New : Form
    {
        Request.WebRequest WEB = new Request.WebRequest();
        WebService navWs = new WebService();

        public New()
        {
            InitializeComponent();
        }

        private void company_DropDown(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!blankcheck())
            {
                if (string.IsNullOrEmpty(company.Text))
                {
                    MessageBox.Show("Select Company", "ERROR!!");
                }
                else
                {
                    WebServiceUrl();
                    SaveToFile();
                    Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }



        public void getCompany()
        {
            if (!blankcheck())
            {
                Uri serviceUrl = getserviceUrl();
                company.Items.Clear();
                company.Text = string.Empty;
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
                MessageBox.Show("Please Fill Required Values", "ERROR!!");
                return true;
            }
            return false;
        }

        public void WebServiceUrl()
        {
            string GeneralURL = string.Empty;
            string CompanyUrl = company.Text.Replace(" ", "%20");
            GeneralURL = string.Format("http://{0}:{1}/{2}/WS/{3}", serverName.Text, soapPort.Text, instanceName.Text, CompanyUrl);
            XmlDocument doc = new XmlDocument();
            string serviceUrl = string.Format("{0}/{1}", GeneralURL, "Services");
            XElement root = new XElement("Root",
                new XElement("operations"));
            var Urls = XElement.Parse(WEB.Resopnse(serviceUrl));
            foreach (XElement url in Urls.Elements())
            {
                var webserviceURL = url.Attribute("ref").Value;
                if (!webserviceURL.Contains("/WS/SystemService"))
                {
                    int pos = webserviceURL.LastIndexOf("/") + 1;
                    var FileName = webserviceURL.Substring(pos, webserviceURL.Length - pos);
                    var WebService = WEB.Resopnse(webserviceURL);
                    navWs.WebServiceReader(WebService, FileName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = true;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                location.Text = folder.SelectedPath;
            }
        }

        public void SaveToFile()
        {
            var credential = new XElement("Credentials",
                new XElement("Server", serverName.Text),
                new XElement("UserName", userName.Text),
                new XElement("password", password.Text),
                new XElement("instance", instanceName.Text),
                new XElement("port", soapPort.Text),
                new XElement("domain", domain.Text),
                new XElement("company", company.Text));

            credential.Save(location.Text +"\\"+ ProjName.Text + ".credentials");
        }
    }
}

