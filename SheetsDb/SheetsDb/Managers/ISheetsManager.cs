using DoMaven.SheetsDb.Models;
using Google.GData.Client;
using Google.GData.Spreadsheets;
using System;
using System.Collections.Generic;
namespace DoMaven.SheetsDb.Managers
{
    public interface ISheetsManager
    {
        void Authenticate();
        bool Authenticated { get; }
        void Test();
        Sheet GetDatabase(bool loadWorksheets = false);
    }
}
