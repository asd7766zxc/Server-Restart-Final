using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final.SQL
{
    public class dboReport
    {
        public int id { get; set; }

        public string ReportType { get; set; }

        public string ReportString { get; set; }

      

        public string fullinfo
        {
            get
            {
                return $"{id} {ReportType} {ReportString}";
            }
        }

    }
}
