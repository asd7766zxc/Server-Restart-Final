using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final.SQL
{
    public static class SQLHelper
    {
       public static ConnectToSQL CTS = new ConnectToSQL();

        public static List<dboReport> GetServerData(string Host,int port,string userid,string userpas,int Dataid)
        {
            CTS.Connect(Host,port,userid,userpas);
           return CTS.GetServerData(Dataid);
        }
    }
}
