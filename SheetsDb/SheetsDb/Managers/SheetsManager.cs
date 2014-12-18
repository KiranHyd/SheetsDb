using DoMaven.SheetsDb.Security;
using Google.GData.Client;
using Google.GData.Spreadsheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoMaven.SheetsDb.Managers
{
    public class SheetsManager : ISheetsManager
    {
        private readonly SpreadsheetsService service;
        private readonly string appName;
        private readonly IAuthentication auth;

        #region Properties
        private bool _authenticated;
        public bool Authenticated {
            get { return _authenticated; } 
        }
        #endregion


        public SheetsManager(string appName, IAuthentication auth)
        {
            this.appName = appName;
            this.service = new SpreadsheetsService(appName);
            this.auth = auth;

            Authenticate();
        }


        public void Authenticate()
        {
            service.setUserCredentials(username: auth.Username, password: auth.Password);
            _authenticated = true;
        }

        public SpreadsheetEntry GetDatabase()
        {
            var query = new SpreadsheetQuery();
            query.Title = appName;

            var feed = service.Query(query);

            var entry = (SpreadsheetEntry)feed.Entries.FirstOrDefault();

            entry.Worksheets.CreateFeedEntry();

            return entry;
        }


        public void Test() {
            var db = GetDatabase();

            //TODO: Remove this
            var x = 1;
            
        }

    }
}
