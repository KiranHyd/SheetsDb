

using Google.GData.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DoMaven.SheetsDb.Security
{
    public class AuthenticationManager
    {
        private readonly Google.GData.Spreadsheets.SpreadsheetsService service;
        private readonly string appName;
        private readonly IAuthentication auth;

        public AuthenticationManager(string appName,IAuthentication auth) {
            this.appName = appName;
            this.service = new Google.GData.Spreadsheets.SpreadsheetsService(appName);
            this.auth = auth;

            Authenticate();
        }

        private void Authenticate() {
            service.setUserCredentials(username: auth.Username, password: auth.Password);
        }

        public IList<AtomEntry> GetSheets() {
            Google.GData.Spreadsheets.SpreadsheetQuery query = new Google.GData.Spreadsheets.SpreadsheetQuery();
            Google.GData.Spreadsheets.SpreadsheetFeed feed = service.Query(query);
            return feed.Entries.ToList();
        }
    }
}
