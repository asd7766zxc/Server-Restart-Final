using Server_Restart_Final;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public static class Logger
{
    public static string LogPath = ProcessCheckStatus.data.ServerFileLocation + @"SFR-Log\lastes.log";
    public static string DoneLogPath = ProcessCheckStatus.data.ServerFileLocation + @"SFR-Log\";
    public static FileStream fs;
    public static void CreateLog()
    {
        LogPath = ProcessCheckStatus.data.ServerFileLocation + @"SFR-Log\lastes.log";
        if (!Directory.Exists(ProcessCheckStatus.data.ServerFileLocation + "SFR-Log"))
        {
            Directory.CreateDirectory(ProcessCheckStatus.data.ServerFileLocation + "SFR-Log");
        }
        if (!File.Exists(ProcessCheckStatus.data.ServerFileLocation + @"SFR-Log\lastes.log"))
        {
            File.Delete(LogPath);
        }
        fs = File.Create(LogPath);
    }
    public static void Log(string log)
    {
        var logbyte = new UTF8Encoding(true).GetBytes(log);
        fs.Write(logbyte,0,logbyte.Length);
    }
    public static void DoneClearLog()
    {
        fs.Close();
        FileInfo fi = new FileInfo(LogPath);
        var cy = fi.OpenRead();
        var cf = File.Create(DoneLogPath+DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+"-"+DateTime.Now.Hour+"-"+DateTime.Now.Minute+"-"+DateTime.Now.Second+".log");
        using (GZipStream cs = new GZipStream(cf, CompressionMode.Compress))
        {
            cy.CopyTo(cf);
        }
    }
}

