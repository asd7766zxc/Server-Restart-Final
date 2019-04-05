using Server_Restart_Final.DataStorage;
using Server_Restart_Final.Event_Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Media;

namespace Server_Restart_Final
{
    public static class ProcessCheckStatus
    {
        public static bool ServerCrash { get; set; } = false;
        public static bool UserControl { get; set; } = false;
        public static bool ServerClose { get; set; } = false;
        public static bool AwaitSendFile { get; set; } = false;
        public static int serverRestartCount { get; set; } = 0;
        public static ServerCrashEvent SCE = new ServerCrashEvent();
        public static Data data = new Data();
        public static Timer CheckUserExit = new Timer { Enabled=data.UserFroceTiming, Interval=6000 }; 
        public static async Task ServerAutoHandler(string CR)
        {
            if (!Global.GlobalSigh.SS.Connected)
             Global.GlobalSigh.SS.ConnectToServer();

            var CrashReport = Global.GlobalSigh._server.OutPutLog;

            Global.GlobalSigh.SS.SendFile(ProcessCheckStatus.data.ServerFileLocation + "\\crash-reports\\" + CR);
            await Task.Delay(1000);
            await Global.GlobalSigh._client.Send(Encoding.UTF8.GetBytes("send|" + CR));
            await RestartServer();
            AwaitSendFile = true;
            CrashReport = "";
          
        }
        public static async Task RestartServer()
        {
            if (serverRestartCount >= data.ServerRestartTimes) return;
            if (UserControl) return;
            try
            {
                await Global.GlobalSigh._client.Send(Encoding.UTF8.GetBytes("SRF-Bot|Try To Restart Server"));
            }
            catch
            {

            }
            
            Global.GlobalSigh._server = new Server(Global.GlobalSigh.mp.OutPut, Global.GlobalSigh.mp, Global.GlobalSigh.mp.CrashOut, Global.GlobalSigh.mp);
            Global.GlobalSigh._server.Type = ServerType.Starting;
            Global.GlobalSigh.AcServerType = ServerType.Starting;
            Global.GlobalSigh._server.CheckDoneCotent();
            Global.GlobalSigh.Tk = new Task(() => Global.GlobalSigh._server.StartServer());
            Global.GlobalSigh.Tk.Start();
            
            var _color = new Color();

            _color = Color.FromRgb(251, 140, 0);
            Global.GlobalSigh.mp.Dispatcher.Invoke(() => {
                Global.GlobalSigh.mp.dt.Start();
                Global.GlobalSigh.mp.Arc1.Fill = new SolidColorBrush(_color);
                Global.GlobalSigh.mp.Arc2.Fill = new SolidColorBrush(_color);
                Global.GlobalSigh.mp.Arc3.Fill = new SolidColorBrush(_color);
                Global.GlobalSigh.mp.Arc4.Fill = new SolidColorBrush(_color);
                Global.GlobalSigh.mp.Arc5.Fill = new SolidColorBrush(_color);
            });
            
            serverRestartCount++;

            if (!Global.GlobalSigh.SS.Connected)
                Global.GlobalSigh.SS.ConnectToServer();

            await Global.GlobalSigh._client.Send(Encoding.UTF8.GetBytes("SRF-Bot|" + "Restart Server: " + serverRestartCount + " " + DateTime.Now));
        }
        public static async Task CommandRestartServer()
        {
            if (Global.GlobalSigh.ServerObjectProc != null)
            {
                Global.GlobalSigh.ServerObjectProc.CloseMainWindow();
            }
          
            Global.GlobalSigh._server = new Server(Global.GlobalSigh.mp.OutPut, Global.GlobalSigh.mp, Global.GlobalSigh.mp.CrashOut, Global.GlobalSigh.mp);
            Global.GlobalSigh._server.CheckDoneCotent();
            Global.GlobalSigh.Tk = new Task(() => Global.GlobalSigh._server.StartServer());
            Global.GlobalSigh._server.Type = ServerType.Starting;
            Global.GlobalSigh.AcServerType = ServerType.Starting;
            Global.GlobalSigh.Tk.Start();
            var _color = new Color();

            _color = Color.FromRgb(251, 140, 0);
            Global.GlobalSigh.mp.Dispatcher.Invoke(() => {
                Global.GlobalSigh.mp.Arc1.Fill = new SolidColorBrush(_color);
                Global.GlobalSigh.mp.Arc2.Fill = new SolidColorBrush(_color);
                Global.GlobalSigh.mp.Arc3.Fill = new SolidColorBrush(_color);
                Global.GlobalSigh.mp.Arc4.Fill = new SolidColorBrush(_color);
                Global.GlobalSigh.mp.Arc5.Fill = new SolidColorBrush(_color);
            });
            if (!Global.GlobalSigh.SS.Connected)
                Global.GlobalSigh.SS.ConnectToServer();

            await Global.GlobalSigh._client.Send(Encoding.UTF8.GetBytes("SRF-Bot|" + "Restart Server: " + "Control:IoC " + DateTime.Now));
        }
    }
}
