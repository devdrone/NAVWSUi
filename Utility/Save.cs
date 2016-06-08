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
        public void StoreCredentials(string server,string user,string pass,string instanc,string port,string domain,string company)
        {
            string[] credentials = { server, user, pass, instanc, port, domain, company };
        }
    }
}
