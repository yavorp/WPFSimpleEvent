using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10a
{
   public class LoginEventAgrs: EventArgs
    {   // event object
        private string password;
        private string username;
        public LoginEventAgrs(string password, string username)
        {
            Username = username;
            Password = password;

        }
        public string    Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
