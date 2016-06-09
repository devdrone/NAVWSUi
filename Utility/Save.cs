using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Utility
{

    public class Save
    {
        public bool SaveCredentials(string[] credentials)
        {
            if(credentials==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SaveToFile()
        {
            SaveFileDialog browser = new SaveFileDialog();
            browser.DefaultExt="credential";
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                var credential = new XElement("Credentials",
                    new XElement("Server", credentials[0]),
                    new XElement("UserName", credentials[1]),
                    new XElement("password", credentials[2]),
                    new XElement("instance", credentials[3]),
                    new XElement("port", credentials[4]),
                    new XElement("domain", credentials[5]),
                    new XElement("company", credentials[6]));

                credential.Save(browser.FileName);
            }         
        }
    }
}
