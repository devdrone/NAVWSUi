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

namespace Editor
{
    public partial class Form1 : Form
    {
        New FormNew = new New();
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
            FormNew.LoadServices(treeView1,progressBar1);
            progressBar1.Visible = false;
        }
    }
}
