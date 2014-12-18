using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoMaven.SheetsDb.Models
{
    public class Sheet
    {
        public string Name { get; set; }

        public IList<WorkSheet> WorkSheets { get; set; }
    }
}
