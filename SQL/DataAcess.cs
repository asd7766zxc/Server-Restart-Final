using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Server_Restart_Final.SQL
{
    public class DataAcess
    {
        public List<dboReport> GetData(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(@"Server=.\SQLExpress;Database=Test;Trusted_Connection=True;"))
            {
                var outs =  connection.Query<dboReport>($"select * from Test where id = '{id}'").ToList();
                return outs;
            }
        }
    }
}
