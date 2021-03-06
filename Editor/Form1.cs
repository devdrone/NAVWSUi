﻿using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Request;
using Services;

namespace Editor
{
    public partial class Form1 : Form
    {
        string soapAction = string.Empty;
        EventLog log = new EventLog();


        string URL = string.Empty;

        New FormNew = new New();

        SOAPBuilder soap = new SOAPBuilder();
        private string UserName;
        private string Password;

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = FormNew.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                FormNew.LoadServices(treeView1, progressBar1);
            }
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
                int pos = str.LastIndexOf("\\") + 1;
                var FileName = str.Substring(pos, str.Length - pos);
                TreeNode Node = treeView1.Nodes.Add(FileName);
                foreach (var file in Directory.GetFiles(str, "*.navwsui"))
                {
                    TreeNode Services = new TreeNode();
                    var str1 = file.Substring(0, file.LastIndexOf("\\"));
                }
            }
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, EventArgs e)
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
            var request = soap.SopaBody(ns, soapBody).ToString();

            RequestBox.Text = request;
        }

        public void LoadResponse()
        {
            WebRequest req = new WebRequest();

            try
            {
                ResponseBox.Text = req.Request(RequestBox.Text, soapAction, URL, UserName, Password).ToString();

                tabControl1.SelectedTab = ResponseTab;
            }
            catch (Microsoft.Dynamics.Nav.Types.Exceptions.NavCSideException ex)
            {
                MessageBox.Show(ex.Message, "ERROR!!!", MessageBoxButtons.OK);
            }
            //catch (Microsoft.Dynamics.Nav.Types.Exceptions.NavCSideException ex)
            //{
            //    MessageBox.Show(ex.Message, "ERROR!!!", MessageBoxButtons.OK);
            //}
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            GetCredentials();
            LoadResponse();
        }

        private void GetCredentials()
        {
            string path = FormNew.GetCredentialFile();
            var credentialFile = XElement.Load(path);

            UserName = credentialFile.Element("UserName").Value;
            Password = credentialFile.Element("password").Value;
        }
    }
}
