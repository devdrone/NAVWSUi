using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Services;

namespace Editor
{
    public partial class New : Form
    {
        Request.WebRequest WEB = new Request.WebRequest();

        WebService navWs = new WebService();

        string GeneralURL = string.Empty;

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
                    Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
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

        // To get the list of companies available in Navision.
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

                //var responsestring = client.UploadString(serviceUrl.ToString(), getNavCompany);
                var responsestring = WEB.Request(getNavCompany, "", serviceUrl.ToString(), userName.Text, password.Text);

                XElement result = XElement.Parse(responsestring.ToString());
                if (result.Descendants(nsSys + "return_value").Any())
                {
                    foreach (var Company in result.Descendants(nsSys + "return_value"))
                    {
                        company.Items.Add(Company.Value);
                    }

                }
            }
        }

        // Creates the Service URL to get all the available webservices
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

        // Blank check of required fields
        public bool blankcheck()
        {
            if (string.IsNullOrEmpty(serverName.Text) || string.IsNullOrEmpty(userName.Text) ||
                string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(instanceName.Text) ||
                string.IsNullOrEmpty(soapPort.Text) || string.IsNullOrEmpty(ProjName.Text))
            {
                MessageBox.Show("Please Fill Required Values", "ERROR!!");
                return true;
            }
            return false;
        }

        // Loads each webservice URL available and creating the corresponding operations file
        public void WebServiceUrl()
        {
            Directory.CreateDirectory(location.Text + "\\" + ProjName.Text);

            string CompanyUrl = company.Text.Replace(" ", "%20");

            GeneralURL = string.Format("http://{0}:{1}/{2}/WS/{3}", serverName.Text, soapPort.Text, instanceName.Text, CompanyUrl);

            XmlDocument doc = new XmlDocument();

            string serviceUrl = string.Format("{0}/{1}", GeneralURL, "Services");

            XElement root = new XElement("Root",
                new XElement("operations"));

            var Urls = XElement.Parse(WEB.Resopnse(serviceUrl, userName.Text, password.Text));
            foreach (XElement url in Urls.Elements())
            {
                var webserviceURL = url.Attribute("ref").Value;

                if (!webserviceURL.Contains("/WS/SystemService"))
                {
                    int pos = webserviceURL.LastIndexOf("/") + 1;

                    var FileName = webserviceURL.Substring(pos, webserviceURL.Length - pos);

                    string filelocation = location.Text + "\\" + ProjName.Text + "\\" + FileName;

                    var WebService = WEB.Resopnse(webserviceURL, userName.Text, password.Text);
                    navWs.WebServiceReader(WebService, filelocation);
                }
            }
        }

        // Save the credentials to a file for future use.
        public void SaveToFile()
        {
            var credential = new XElement("Credentials",
                new XElement("Server", serverName.Text),
                new XElement("UserName", userName.Text),
                new XElement("password", password.Text),
                new XElement("instance", instanceName.Text),
                new XElement("port", soapPort.Text),
                new XElement("domain", domain.Text),
                new XElement("company", company.Text),
                new XElement("URL", GeneralURL));

            credential.Save(location.Text + "\\" + ProjName.Text + "\\" + ProjName.Text + ".credentials");
        }

        public string GetCredentialFile()
        {
            string Destination = location.Text + "\\" + ProjName.Text + "\\" + ProjName.Text + ".credentials";
            return Destination;
        }

        public TreeView LoadServices(TreeView treeViewMain, ProgressBar progressbarMain)
        {
            if (!string.IsNullOrEmpty(serverName.Text) && !string.IsNullOrEmpty(userName.Text) &&
                !string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(instanceName.Text) &&
                !string.IsNullOrEmpty(soapPort.Text) && !string.IsNullOrEmpty(ProjName.Text))
            {
                try
                {
                    progressbarMain.Visible = true;

                    XmlDocument credentialDoc = new XmlDocument();
                    XmlDocument serviceDoc = new XmlDocument();

                    TreeNode MainNode = treeViewMain.Nodes.Add(ProjName.Text);

                    List<string> services = new List<string>();

                    credentialDoc.Load(location.Text + "\\" + ProjName.Text + "\\" + ProjName.Text + ".credentials");

                    var credentials = XElement.Parse(credentialDoc.InnerXml);
                    var serviceUrl = string.Format("{0}/{1}", credentials.Element("URL").Value, "Services");

                    var Urls = XElement.Parse(WEB.Resopnse(serviceUrl, userName.Text, password.Text));

                    progressbarMain.Minimum = 0;
                    progressbarMain.Maximum = Urls.Elements().Count();

                    foreach (XElement url in Urls.Elements())
                    {
                        var webserviceURL = url.Attribute("ref").Value;

                        if (!webserviceURL.Contains("/SystemService"))
                        {
                            TreeNode ServiceNode = new TreeNode();

                            int pos = webserviceURL.LastIndexOf("/") + 1;
                            var FileName = webserviceURL.Substring(pos, webserviceURL.Length - pos);

                            ServiceNode.Text = FileName;
                            serviceDoc.Load(location.Text + "\\" + ProjName.Text + "\\" + FileName + ".navwsui");

                            var serviceFiles = XElement.Parse(serviceDoc.InnerXml);
                            foreach (var serviceFile in serviceFiles.Elements())
                            {
                                TreeNode OperationNode = new TreeNode();
                                OperationNode.Text = serviceFile.Name.LocalName;
                                ServiceNode.Nodes.Add(OperationNode);
                            }
                            MainNode.Nodes.Add(ServiceNode);
                        }
                        progressbarMain.Increment(1);
                    }
                    return treeViewMain;
                }
                catch { return treeViewMain; }
            }
            return treeViewMain;
        }

        public string Path()
        {
            string path = location.Text + "\\" + ProjName.Text;
            return path;
        }

        private void company_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

