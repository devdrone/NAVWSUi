using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Request;
using Services;
using System.IO;
using System.Diagnostics;

namespace Editor
{
    public partial class Form1 : Form
    {
        string soapAction = string.Empty;
        EventLog log = new EventLog();
        
        
        string URL = string.Empty;

        New FormNew = new New();

        SOAPBuilder soap = new SOAPBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNew.Show();
        }

        private void FormNew_Deactivate(object sender, EventArgs e)
        {
            FormNew.LoadServices(treeView1, progressBar1);

            progressBar1.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            openfile.Filter = "credentials files (*.credentials)|*.credentials";

            DialogResult result = openfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                var str = openfile.FileName.Substring(0, openfile.FileName.LastIndexOf("\\"));
                foreach (var file in Directory.GetFiles(str, "*.navwsui"))
                {

                }
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.FirstNode != null)
            {
                treeView1.SelectedNode.Expand();
            }
            else
            {
                LoadRequest(treeView1.SelectedNode.Parent.Text, treeView1.SelectedNode.Text);
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            LoadResponse();
        }

        public void LoadRequest(String fileName, string operation)
        {
            string path = FormNew.Path();

            XmlDocument doc = new XmlDocument();

            doc.Load(path + "\\" + fileName + ".navwsui");

            var OperationFile = XElement.Parse(doc.InnerXml);

            XNamespace ns = OperationFile.GetNamespaceOfPrefix("ins").NamespaceName;

            soapAction = OperationFile.Element(ns + operation).Element("soapAction").Value;
            OperationFile.Element(ns + operation).Element("soapAction").Remove();
            URL = OperationFile.Element("URL").Value;

            XElement soapBody = OperationFile.Element(ns + operation);
            var request = soap.sopaBody(ns, soapBody).ToString();

            RequestBox.Text = request;
        }

        public void LoadResponse()
        {
            WebRequest req = new WebRequest();

            try
            {
                ResponseBox.Text = req.Request(RequestBox.Text, soapAction, URL).ToString();

                tabControl1.SelectedTab = ResponseTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!!!", MessageBoxButtons.OK);
            }
        }
    }
}
