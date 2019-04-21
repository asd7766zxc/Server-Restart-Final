using Server_Restart_Final.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final
{
    public class ConnectToSQL
    {
        List<dboReport> Report = new List<dboReport>();
        public ConnectToSQL()
        {
            DataAcess asc = new DataAcess();
            Report =  asc.GetData(1);
        }     
    }
}
