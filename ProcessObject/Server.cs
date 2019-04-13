using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Controls;
using TextBox = System.Windows.Controls.TextBox;
using System.Windows;
using System.Timers;
using Application = System.Windows.Forms.Application;
using Label = System.Windows.Controls.Label;
using System.Windows.Media;
using Timer = System.Timers.Timer;

namespace Server_Restart_Final
{
    public class Server
    {
        public Process ServerObject;
        public bool AutoRestart;
        public TextBox Tb;
        public ServerType Type;
        public ServerType AuicalType;
        private string log = "";
        private Process[] processlist;
        private string od_Text = "";
        private string nw_Text = "";
        public string OutPutLog;
        public string ExitCode_Server;
        public Timer timer1 = new Timer();
        public Page Win;
        public Label Lab;
        public MainPage mp;
        public bool serverdone = false;
        DirectoryInfo di = new DirectoryInfo(ProcessCheckStatus.data.ServerFileLocation + "\\crash-reports\\");
        FileInfo[] fi;
        public delegate void Invokes(string sp);
        public delegate void Invoker();

        public Server(TextBox tb, Page win, Label lab, MainPage _mp)
        {
            Tb = tb;
            Win = win;
            Lab = lab;
            mp = _mp;
            Type = ServerType.Close;
            Global.GlobalSigh.AcServerType = ServerType.Close;
            lockmessage = true;
        }

        public void StartServer()
        {
            Win.Dispatcher.Invoke(() => { Tb.Text = ""; });
            try
            {
                fi = di.GetFiles();
                foreach (var value in fi)
                {
                    od_Text += value.Name;
                }
            
                var path0 = "\"" + ProcessCheckStatus.data.ServerFileLocationName + "\"";
                var path1 = ProcessCheckStatus.data.ServerFileLocation;
                var processInfo = new ProcessStartInfo("cmd.exe", "/c " + path0);
                processInfo.WorkingDirectory = ProcessCheckStatus.data.ServerFileLocation;
                processInfo.CreateNoWindow = false;
                processInfo.UseShellExecute = false;
                processInfo.RedirectStandardInput = true;
                processInfo.RedirectStandardError = true;
                processInfo.RedirectStandardOutput = true;
                Logger.CreateLog();
                ServerObject = Process.Start(processInfo);
                Global.GlobalSigh.ServerObjectProc = ServerObject;
                ServerObject.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
                ServerObject.BeginOutputReadLine();

                ServerObject.ProcessorAffinity = (IntPtr)2;


                ServerObject.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
                ServerObject.BeginErrorReadLine();

                ServerObject.Exited += new EventHandler(Process_Exited);
                ServerObject.WaitForExit();



                ExitCode_Server = "" + ServerObject.ExitCode;
                ServerObject.Close();
            }
            catch { }
        }

        public void CheckDoneCotent()
        {
            timer1 = new Timer
            {
                Enabled = true,
                Interval = 1,
                AutoReset = true,

            };

            timer1.Elapsed += Timer1_Tick;

        }

        public bool lockmessage = true;
        private async void Timer1_Tick(object sender, EventArgs e)
        {
            var logs = log.Split(' ');

            foreach (var Instaned in logs)
            {
                if (Instaned == "Done")
                {
                    ProcessCheckStatus.serverRestartCount = 0;
                    timer1.Enabled = false;
                    Type = ServerType.Idle;
                    Global.GlobalSigh.AcServerType = ServerType.Idle;
                    serverdone = true;
                    Global.GlobalSigh._server = this;


                    if (lockmessage)
                    {
                        try
                        {
                            await Global.GlobalSigh._client.Send(Encoding.UTF8.GetBytes("SRF-Bot|" + "Server Start Done " + DateTime.Now));
                            lockmessage = false;
                        }
                        catch { }
                    }

                    ProcessCheckStatus.serverRestartCount = 0;
                    Win.Dispatcher.Invoke(() =>
                    {
                        var _color = new Color();

                        _color = Color.FromRgb(3, 169, 244);
                        mp.Arc1.Fill = new SolidColorBrush(_color);
                        mp.Arc2.Fill = new SolidColorBrush(_color);
                        mp.Arc3.Fill = new SolidColorBrush(_color);
                        mp.Arc4.Fill = new SolidColorBrush(_color);
                        mp.Arc5.Fill = new SolidColorBrush(_color);
                    });
                }

            }
        }

        private void Process_Exited(object sender, EventArgs e)
        {

            Logger.DoneClearLog();
            if (Type == ServerType.UserControl) return;
            outerhandle();
            Global.GlobalSigh.AcServerType = ServerType.Close;
            Type = ServerType.Close;
            Global.GlobalSigh.AcServerType = ServerType.Stopped;
            try
            {
                Global.GlobalSigh.Tk.Dispose();
                Global.GlobalSigh.Tk = null;
                ProcessCheckStatus.ServerClose = true;
                ProcessCheckStatus.SCE.CheckServerCrash();
                lockmessage = true;
            }
            catch
            {

            }
        }
        public void outerhandle()
        {
            fi = di.GetFiles();
            foreach (var value in fi)
            {
                nw_Text += value.Name;
            }
            var tss = "";
            try
            {
                tss = nw_Text.Remove(0, od_Text.Length);
            }
            catch { }
            nw_Text = "";
            od_Text = "";
            OutPutLog = tss;
            if (File.Exists(ProcessCheckStatus.data.ServerFileLocation + "\\crash-reports\\" + tss))
            {

                Type = ServerType.Crash;
                ProcessCheckStatus.ServerAutoHandler(tss);
                ProcessCheckStatus.ServerCrash = true;
                ProcessCheckStatus.SCE.CheckServerCrash();
            }
            else
            {

            }
            Win.Dispatcher.Invoke(() => { Lab.Content = "Last Crash: " + tss; });
            Win.Dispatcher.Invoke(() =>
            {
                var _color = new Color();

                _color = Color.FromRgb(189, 189, 189);
                mp.timer1.Enabled = false;
                mp.Arc1.Fill = new SolidColorBrush(_color);
                mp.Arc2.Fill = new SolidColorBrush(_color);
                mp.Arc3.Fill = new SolidColorBrush(_color);
                mp.Arc4.Fill = new SolidColorBrush(_color);
                mp.Arc5.Fill = new SolidColorBrush(_color);
            });
            Global.GlobalSigh.Tk = null;
            Global.GlobalSigh.CloseServerNull(this);
        }

        public async Task RestartServer()
        {
            if (OutPutLog != null || OutPutLog != "")
            {
                CloseServer();
                await Task.Delay(1000);
                StartServer();
            }
        }
        public async Task RestartServer(bool Force)
        {
            if (Force)
            {
                CloseServer();
                await Task.Delay(1000);
                StartServer();
            }
        }

        private void OutputHandler(object sender, DataReceivedEventArgs e)
        {
            log += e.Data + "\n";
            Win.Dispatcher.Invoke(() => { Tb.AppendText(e.Data + "\n"); Tb.ScrollToEnd(); });
        }

        public void CloseServer()
        {
            if (ServerObject == null) return;

            killProc(ServerObject);

        }
        public void killProc(Process target)
        {
            target.CloseMainWindow();
        }
    }
}
