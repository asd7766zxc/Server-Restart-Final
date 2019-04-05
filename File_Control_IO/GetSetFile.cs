using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_Restart_Final
{
    public static class GetSetFile
    {
        public static void GetFile(string filename)
        {
            if (!Global.GlobalSigh.SS.Connected)
                Global.GlobalSigh.SS.ConnectToServer();



            Global.GlobalSigh.SS.SendFile(ProcessCheckStatus.data.ServerFileLocation + filename);
        }
        public static void SetFile(string filenames)
        {
            var sf = filenames.Split(',');
            if (File.Exists(Application.StartupPath + "\\Transfers\\" + sf[1]))
            {
                if (File.Exists(ProcessCheckStatus.data.ServerFileLocation + sf[0] + "\\" + sf[1]))
                {
                    File.Delete(ProcessCheckStatus.data.ServerFileLocation + sf[0] + "\\" + sf[1]);
                }
                System.IO.File.Move(Application.StartupPath + "\\Transfers\\" + sf[1], ProcessCheckStatus.data.ServerFileLocation + sf[0]+"\\"+sf[1]);
            }
        }
        public static async Task awaitdel(string f)
        {
            await Task.Delay(1000000);
            File.Delete(Application.StartupPath + "\\Transfers\\" + f);
        }
        static DirectoryInfo d;
        public static void GetFloder(string path)
        {

            d = new DirectoryInfo(Application.StartupPath + path);
            var files = d.GetFiles();
            var floder = d.GetDirectories();
            string str = "";
            string ltr = "";
            foreach (var f in files)
            {
                str = str + "," + f.Name;
            }
            foreach (var ds in floder)
            {
                ltr = ltr + "," + ds.Name;
            }
            Global.GlobalSigh._client.Send(Encoding.UTF8.GetBytes("SD|"+ltr+","+str));
        }
    }
}
