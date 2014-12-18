using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoMaven.SheetsDb.Security
{
    public interface IAuthentication
    {
        string Username { get; }
        string Password { get; }
    }
}
