using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public class Save
    {
        string[] credentials = new string[7];
        public void StoreCredentials(string server,string user,string pass,string instanc,string port,string domain,string company)
        {
            credentials[0] = server;
            credentials[1] = user;
            credentials[2] = pass;
            credentials[3] = instanc;
            credentials[4] = port;
            credentials[5] = domain;
            credentials[6] = company;
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
    }
}
