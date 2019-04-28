using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Server_Restart_Final.Event_Handler;
using Server_Restart_Final.Pages;
using Server_Restart_Final.SocketClient;
using ServerRestartFinal.Core.IoC;

namespace Server_Restart_Final.Global
{

    public static class GlobalSigh
    {
        public static PerformanceCounter pc = new PerformanceCounter();
        public static ParameterBuilder PB;
        public static string TreeViewItemTag { get; set; }
        public static SocketStaus SS = new SocketStaus(ProcessCheckStatus.data.SQLServerLoaction, 10270);
        public static Client _client = new Client();
        public static Task LoggerTask { get; set; }
        public static ApplicationPage PageType { get; set; }
        public static MainWindow mw { get; set; }
        public static SideMenuControl sidem { get; set; }
        public static Frame fr { get; set; }
        public static Frame lf { get; set; }
        public static Particles pe { get; set; }
        public static TopMenuPage tmp { get; set; }
        public static ServerType AcServerType { get; set; }
        public static List<ChatlistItemViewModel> _Item { get; set; }
        public static MainPage mp = new MainPage();
        public static ReportPage rp = new ReportPage();
        public static InfoPage ip = new InfoPage();
        public static SetttingPage sp = new SetttingPage();
        public static LoadingPage lp = new LoadingPage();
        public static Task UpateTask_;
        public static Process ServerObjectProc;
        public static Server _server;
        public static Server_UI_Update_Event_Handler SUUEH;
        public static Task Tk;
        public static Label reports;
        public static Label reportst;
        public static TextBox IoCOut;
        public static int TranserValueProgress { get { return transerValueProgress; } set { transerValueProgress = value; TransferUpdate(value); } }
        public static int transerValueProgress;
        public static List<TransferQueue> LisOfQueue = new List<TransferQueue>();
        public static void GlobalMethod(ApplicationPage pages)
        {
            if (CurrentPages(pages) == mp)
            {
                if (ProcessCheckStatus.data.command.Count < 10)
                {
                    MessageBox.Show("Missed Command!");
                    return;
                }
            }
            fr.Content = CurrentPages(pages);
            fr.Content =new ServerPage();
        }
        public static void ConnectToSQLServer()
        {
            var rep = SQL.SQLHelper.GetServerData("cr-reports.ddns.net", 1433, "central-server", "central-pas", 1);
            foreach (var item in rep)
            {
                MessageBox.Show(item.fullinfo);
            }
        }
        public static void TreeViewItemClick()
        {
            string cmd = "explorer.exe";
            string arg = "/select, " + TreeViewItemTag;
            Process.Start(cmd, arg);
        }
        public static void SendComplete(string msg)
        {
        }
        public static void ApplicationClosing()
        {
            Task.Run(() => { Logger.DoneClearLog(); }); 
            SS.ClearComplete();
            SS.CloseClient();
            SS.transferClient = null;

            _client = null;
            if (ServerObjectProc != null)
            {
                ServerObjectProc.CloseMainWindow();
            }

            Environment.Exit(0);
        }
        public static void CloseServerNull(Server s)
        {
            _server = null;
        }
        public static void UpdateConnectStaus(string msg)
        {
        }
        public static void ChangeSideBar(bool ise)
        {
            ise = true;
        }
        static bool isOpenSideMenu = true;
        public static void ChangeSideMenu()
        {
            if (isOpenSideMenu)
            {
                sidem.Width = 60;
                isOpenSideMenu = false;
            }
            else
            {
                sidem.Width = 140;
                isOpenSideMenu = true;
            }
                
        }
        public static void TransferUpdate(string ids,string filename,string type,string progress)
        {
            rp.Dispatcher.Invoke(() => {
                reportst.Content = DateTime.Now.ToString();
                reports.Content = "ID: " + ids + "\n" + "File: " + filename + "\n" + "Type: " + type; });

        }
        public static void TransferUpdate(int progress)
        {
           
        }
        public static Page CurrentPages(ApplicationPage p)
        {
            switch (p)
            {
                case ApplicationPage.Info:
                    return ip;
                case ApplicationPage.Report:
                    return rp;
                case ApplicationPage.Settings:
                    return sp;
                case ApplicationPage.Main:
                    return mp;
                default:
                    return null;

            }
        }
    }
}
