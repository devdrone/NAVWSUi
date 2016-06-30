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

namespace Editor
{
    public partial class Form1 : Form
    {
        string soapAction = string.Empty;
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
            LoadRequest(treeView1.SelectedNode.Parent.Text,treeView1.SelectedNode.Text);
        }

        public void LoadRequest(String fileName,string operation)
        {
            string path = FormNew.Location();

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
    }
}
