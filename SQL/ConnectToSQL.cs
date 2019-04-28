using Server_Restart_Final.DataStorage;
using Server_Restart_Final.SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final
{
    public class ConnectToSQL
    {
        public SqlConnection conn;
        public List<dboReport> Report = new List<dboReport>();
        DataAcess asc = new DataAcess();
      
        public void Connect(string Host,int port,string userid,string userpas)
        {
           conn = new SqlConnection($"Server={Host},{port};  initial catalog = Test; user id = {userid}; password = {userpas}");
            conn.Open();
        }
        public List<dboReport> GetServerData(int id)
        {
            if (conn == null) return null;

            var report = asc.GetData(id,conn);
            return report;
        }
        public List<Data> GetServerParameter()
        {
            return null;
        }
    }
}
