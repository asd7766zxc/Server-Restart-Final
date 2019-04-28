using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Server_Restart_Final.SQL
{
    public class DataAcess
    {
        public List<dboReport> GetData(int id,SqlConnection conn)
        {
            IDbConnection ics = conn;
            return ics.Query<dboReport>($"select * from Test where id = {id}").ToList();
        }
    }
}
