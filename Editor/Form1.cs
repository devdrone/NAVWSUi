using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        Utility.Save save = new Utility.Save();
        New newform = new New();
        
        public Form1()
        {
            InitializeComponent();
            newform.SaveInitialLogin();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New FormNew = new New();
            FormNew.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (!save.SaveCredentials())
            {
                if (MessageBox.Show("Save Before Closing !!!!", "NAVWSUi - Save", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    save.SaveToFile();
                }
            }

        }
    }
}
