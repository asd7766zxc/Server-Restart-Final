using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final.StorageBatch
{
    public static class Batch
    {
        public static void SaveBatch(string parameter)
        {
            if (!File.Exists(ProcessCheckStatus.data.ServerFileLocationName))
            {
                File.WriteAllBytes(ProcessCheckStatus.data.ServerFileLocationName , Encoding.UTF8.GetBytes(parameter));
            }
            else
            {
                File.Delete(ProcessCheckStatus.data.ServerFileLocationName);
                File.WriteAllBytes(ProcessCheckStatus.data.ServerFileLocationName, Encoding.UTF8.GetBytes(parameter));
            }
        }
        public static string LoadBatch()
        {
            var outi = "";
            outi = Encoding.UTF8.GetString(File.ReadAllBytes(ProcessCheckStatus.data.ServerFileLocationName));
            return outi;
        }
    }
}
