using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoMaven.SheetsDb.Security
{
    public class GoogleAuthentication : IAuthentication
    {
        private string _username;
        private string _password;

        public GoogleAuthentication(string username, string password) {
            this._username = username;
            this._password = password;
        }

        public string Username
        {
            get { return _username; }
        }

        public string Password
        {
            get { return _password; }
        }
    }
}
