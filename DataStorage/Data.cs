using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final.DataStorage
{
    public class Data
    {
        public string ServerFileLocation { get; set; }
        public string ServerFileLocationName { get; set; }
        public string ServerFileLocationFloder { get; set; }
        public string SQLServerLoaction { get; set; }
        public bool UserFroceTiming { get; set; }
        public int ServerRestartTimes { get; set; }
        public string parameter { get; set; }
        public List<Commands> command { get; set; } 
        public string Memory { get; set; } 
    }
}
