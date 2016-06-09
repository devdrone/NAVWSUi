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
        public string[] credentials;
        public void StoreCredentials(string server, string user, string pass, string instanc, string port, string domain, string company)
        {
            credentials = new string[7];
            if (!string.IsNullOrEmpty(server) && !string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(instanc) && !string.IsNullOrEmpty(port)
                && !string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(company))
            {
                credentials[0] = server;
                credentials[1] = user;
                credentials[2] = pass;
                credentials[3] = instanc;
                credentials[4] = port;
                credentials[5] = domain;
                credentials[6] = company;
            }
            else
            {
                credentials = null;
            }
        }

        public bool SaveCredentials()
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
