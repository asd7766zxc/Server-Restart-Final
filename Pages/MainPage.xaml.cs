using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace Server_Restart_Final
{
    /// <summary>
    /// MainPage.xaml 的互動邏輯
    /// </summary>
    public partial class MainPage : Page
    {
        public Device device;
        public Server _server;
        public Timer timer1;
        public DispatcherTimer dt = new DispatcherTimer();
        public DispatcherTimer dt1 = new DispatcherTimer();
        public string Command = "YOOOO";
        public int _progress { get; set; }

        public MainPage()
        {
            dt.Interval = TimeSpan.FromSeconds(0.1);
            dt.Tick += Dt_Tick;

            dt1.Interval = TimeSpan.FromMilliseconds(1);
            dt1.Tick += Dt1_Tick;
       
            this.Loaded += MainPage_Loaded;
            InitializeComponent();
            timer1 = new Timer
            {
                Enabled = false,
                AutoReset = true,
                Interval = 100,

            };
            timer1.Elapsed += Timer_Elapsed;

            _server = new Server(this.OutPut, this, this.CrashOut, this);
            Global.GlobalSigh._server = this._server;
        }
        int i = 0;
        private void Dt1_Tick(object sender, EventArgs e)
        {
        
            i++;
            Dispatcher.Invoke(() =>
            {
                this.Arc1.RenderTransform = TransformRT(i);
                this.Arc2.RenderTransform = TransformRT(i*2);
                this.Arc3.RenderTransform = TransformRT(i);
                this.Arc4.RenderTransform = TransformRT(i);
                this.Arc5.RenderTransform = TransformRT(i);
            });
          
        }
        public RotateTransform TransformRT(double angle)
        {
            var rt = new RotateTransform();
            rt.CenterX = 0;
            rt.CenterY = 50;
            rt.Angle = angle;
            return rt;
        }
        public int Server_Restart_Countdown = 100;
        private void Dt_Tick(object sender, EventArgs e)
        {
            if (Global.GlobalSigh.AcServerType == ServerType.Stopped)
            {
                StoppedOut.Content = DateTime.Now + "\n" + "Server Stopped! Will Restart At " + Server_Restart_Countdown/10;
                Server_Restart_Countdown--;
                ProcessCheckStatus.serverRestartCount = 0;
                if (Server_Restart_Countdown < 10)
                {
                    Server_Restart_Countdown = 100;
                    Global.GlobalSigh.AcServerType = ServerType.Starting;
                    
                    ProcessCheckStatus.RestartServer();
                }
            }
            else
            {
                StoppedOut.Content = DateTime.Now + "\n";
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(() =>
            {
                try
                {
                    this.ServerState.Content = "" + Global.GlobalSigh._server.ServerObject.StartTime + "\n" + Global.GlobalSigh._server.ServerObject.TotalProcessorTime + "\n" + Global.GlobalSigh._server.ServerObject.WorkingSet64;
                }
                catch { timer1.Enabled = false; }
            });
        }
        public void f()
        {
            Ellipse_Particle ep = new Ellipse_Particle(this.DrawCanvas);
            ep.Draw();
            ep = null;
        }
        public Button[] btnarray = new Button[10];
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
         
            btnarray[0] = CommandBtn;
            btnarray[1] = CommandBtn1;
            btnarray[2] = CommandBtn2;
            btnarray[3] = CommandBtn3;
            btnarray[4] = CommandBtn4;
            btnarray[5] = CommandBtn5;
            btnarray[6] = CommandBtn6;
            btnarray[7] = CommandBtn7;
            btnarray[8] = CommandBtn8;
            btnarray[9] = CommandBtn9;

            for (int i = 0; i < btnarray.Length; i++)
            {
                btnarray[ProcessCheckStatus.data.command[i].commandindex].Content =  ProcessCheckStatus.data.command[i].command;
            }
            Global.GlobalSigh.IoCOut = this.IoCOutPut;
            this.OutPut.MaxLength = 0;
            IMainFrame.Content = Global.GlobalSigh.rp;
        }

        private void StartServerBtn_Click(object sender, RoutedEventArgs e)
        {
            var _color = new Color();

            _color = Color.FromRgb(251, 140, 0);
            this.Arc1.Fill = new SolidColorBrush(_color);
            this.Arc2.Fill = new SolidColorBrush(_color);
            this.Arc3.Fill = new SolidColorBrush(_color);
            this.Arc4.Fill = new SolidColorBrush(_color);
            this.Arc5.Fill = new SolidColorBrush(_color);
            _server.CheckDoneCotent();
            _server.Type = ServerType.Starting;
            Global.GlobalSigh.AcServerType = ServerType.Starting;
            Global.GlobalSigh.Tk = new Task(() => _server.StartServer());
            Global.GlobalSigh.Tk.Start();
            Global.GlobalSigh._server = _server;
            timer1.Start();
            dt.Start();
        }

        private async void ServerInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                try
                {
                    if (Global.GlobalSigh._server.serverdone == true)
                    {
                        await Global.GlobalSigh._server.ServerObject.StandardInput.WriteLineAsync(this.ServerInput.Text);
                        this.ServerInput.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Serve Still Starting Or Close", "Error", MessageBoxButton.OK);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
                }
            }

        }

        private void RestartServerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Global.GlobalSigh.ServerObjectProc != null)
            {
                _server.Type = ServerType.Starting;
                Global.GlobalSigh.ServerObjectProc.CloseMainWindow();

                Global.GlobalSigh._server = new Server(this.OutPut, this, this.CrashOut, this);
                Global.GlobalSigh._server.Type = ServerType.Starting;
                Global.GlobalSigh._server.CheckDoneCotent();
                Global.GlobalSigh.Tk = new Task(() => Global.GlobalSigh._server.StartServer());
                Global.GlobalSigh.Tk.Start();
                var _color = new Color();

                _color = Color.FromRgb(251, 140, 0);
                this.Arc1.Fill = new SolidColorBrush(_color);
                this.Arc2.Fill = new SolidColorBrush(_color);
                this.Arc3.Fill = new SolidColorBrush(_color);
                this.Arc4.Fill = new SolidColorBrush(_color);
                this.Arc5.Fill = new SolidColorBrush(_color);
            }
            else
            {
                MessageBox.Show("Serve Still Starting Or Close", "Error", MessageBoxButton.OK);
            }

        }

        private void StopServerBtn_Click(object sender, RoutedEventArgs e)
        {
            var _color = new Color();
            _color = Color.FromRgb(189, 189, 189);
            timer1.Enabled = false;
            Arc1.Fill = new SolidColorBrush(_color);
            Arc2.Fill = new SolidColorBrush(_color);
            Arc3.Fill = new SolidColorBrush(_color);
            Arc4.Fill = new SolidColorBrush(_color);
            Arc5.Fill = new SolidColorBrush(_color);
            Global.GlobalSigh._server.Type = ServerType.UserControl;
            Global.GlobalSigh.AcServerType = ServerType.UserControl;
            if (Global.GlobalSigh.ServerObjectProc != null)
            {
                Global.GlobalSigh.ServerObjectProc.CloseMainWindow();
            }
        }

        private void CommandBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var senders = (Button)sender;
                if (Global.GlobalSigh._server.serverdone == true)
                {
                    Global.GlobalSigh._server.ServerObject.StandardInput.WriteLineAsync(senders.Content + "");
                    this.ServerInput.Text = "";
                }
                else
                {
                    MessageBox.Show("Serve Still Starting Or Close At Command: " + senders.Content, "Error", MessageBoxButton.OK);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK);
            }
        }
    }
}
