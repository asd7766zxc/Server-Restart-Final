using Server_Restart_II;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Timer = System.Timers.Timer;
using Server_Restart_Final.DataStorage;

namespace Server_Restart_Final
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public double WindowHeight { get { return Application.Current.MainWindow.Height; } set { Main.Height = value; } }
        public ApplicationPage CurrentPage = Global.GlobalSigh.PageType;
        public Timer timer1;
        public Server _server;
        public MainPage _MainPage = new MainPage();
        public MainWindow()
        {
            this.Main = this;
            this.DataContext = new WindowsVeiwModles(this);
            this.Loaded += MainWindow_Loaded;
            this.MouseDown += MainWindow_MouseDown;
            this.Closing += MainWindow_Closing;
            this.MouseMove += MainWindow_MouseMove;
            timer1 = new Timer
            {
                Enabled=false,
                AutoReset=true,
                Interval=700,

            };
            timer1.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke((Action)(() =>
            {
                f();
            }));

           
        }
        public void f()
        {
            Ellipse_Particle ep = new Ellipse_Particle(_MainPage.DrawCanvas);
            ep.Draw();
            ep = null;
        }
        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            _MainPage.Out.Text = "" + e.GetPosition(_MainPage.DrawCanvas);
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Global.GlobalSigh.ApplicationClosing();
        }


        public Ellipse cir;
        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }
     
        protected override void OnRender(DrawingContext dc)
        {
        }
        public async Task SizeMin()
        {
            for (int i = 100; i >= 30; i -= 2)
            {
                await Task.Delay(1);
                this.Dispatcher.Invoke((Action)(() =>
                {
                    cir.Height = i;
                    cir.Width = i;
                }));

            }
        }
        public async Task Move_Control(object sender, MouseButtonEventArgs e)
        {
            Point MousePoint = e.GetPosition(_MainPage.DrawCanvas);
            var PosX = (int)(MousePoint.X - (cir.Width / 2));
            var PosY = (int)(MousePoint.Y - (cir.Height / 2));

            int MainHeight = (int)_MainPage.DrawCanvas.Height;
            int MainWidth = (int)_MainPage.DrawCanvas.Width;
            var MarginHeight = MainHeight - (PosY + (int)SystemParameters.CaptionHeight + (int)SystemParameters.BorderWidth + 4);
            var MarginWidth = MainWidth - (PosX + (int)SystemParameters.BorderWidth);
            cir.Margin = new Thickness(PosX, PosY, MarginWidth, MarginHeight);
            for (int i = 0; i <= 1000; i++)
            {
                await Task.Delay(1);
                this.Dispatcher.Invoke((Action)(() =>
                {
                    cir.Margin = new Thickness(PosX, PosY - i, MarginWidth, MarginHeight + i);
                }));
            }
        }
        Random r = new Random();
        public async Task Move_Control()
        {
            Point MousePoint = new Point(r.Next(0, 500), 500);
            var PosX = (int)(MousePoint.X - (cir.Width / 2));
            var PosY = (int)(MousePoint.Y - (cir.Height / 2));

            int MainHeight = (int)_MainPage.DrawCanvas.Height;
            int MainWidth = (int)_MainPage.DrawCanvas.Width;
            var MarginHeight = MainHeight - (PosY + (int)SystemParameters.CaptionHeight + (int)SystemParameters.BorderWidth + 4);
            var MarginWidth = MainWidth - (PosX + (int)SystemParameters.BorderWidth);
            cir.Margin = new Thickness(PosX, PosY, MarginWidth, MarginHeight);
            for (int i = 0; i <= 1000; i++)
            {
                await Task.Delay(1);
                this.Dispatcher.Invoke((Action)(() =>
                {
                    cir.Margin = new Thickness(PosX, PosY - i, MarginWidth, MarginHeight + i);
                }));
            }
        }
        public void Move_Control(object sender, Point p)
        {
            Point MousePoint = p;
            var PosX = (int)(MousePoint.X - 115 - 50);
            var PosY = (int)(MousePoint.Y - 55 - 50);

            int MainHeight = (int)_MainPage.DrawCanvas.Height;
            int MainWidth = (int)_MainPage.DrawCanvas.Width;
            var MarginHeight = MainHeight - (PosY + (int)SystemParameters.CaptionHeight + (int)SystemParameters.BorderWidth + 4);
            var MarginWidth = MainWidth - (PosX + (int)SystemParameters.BorderWidth);
            cir.Margin = new Thickness(PosX, PosY, MarginWidth, MarginHeight);
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ProcessCheckStatus.data = StorageData.FromXmlFile<Data>(System.Windows.Forms.Application.StartupPath + "\\LocalData.xml");
            Global.GlobalSigh.SS.ConnectToServer();
            Global.GlobalSigh._client.Connect(ProcessCheckStatus.data.SQLServerLoaction,10127);
            ProcessCheckStatus.CheckUserExit.Elapsed += CheckUserExit_Elapsed;
            ProcessCheckStatus.CheckUserExit.Enabled = ProcessCheckStatus.data.UserFroceTiming;
            SideMenu.Width = 60;
            Global.GlobalSigh.lf = this.LoadingFrame;
            this.WindowState = WindowState.Normal;
            Global.GlobalSigh.sidem = this.SideMenu;
            Global.GlobalSigh.sidem.CPMenu = this.SideMenu.CPMenu;
            Global.GlobalSigh.sidem.CPMenu = new RelayCommand(Global.GlobalSigh.ChangeSideMenu);
            Global.GlobalSigh.fr = this.MainFrame;
            Global.GlobalSigh.mw = this;
            cir = new Ellipse();
            cir.StrokeThickness = 1;
            cir.Stroke = Brushes.AliceBlue;
            cir.Height = 300;
            cir.Width = 300;
            Point R = new Point(_MainPage.DrawCanvas.Height / 2, _MainPage.DrawCanvas.Width / 2);
            Move_Control(sender, R);
            _MainPage.DrawCanvas.Children.Add(cir);
        }


        private void CheckUserExit_Elapsed(object sender, ElapsedEventArgs e)
        {
            ProcessCheckStatus.UserControl = false;
        }

        private async void StartServerBtn_Click(object sender, RoutedEventArgs e)
        {
           await Task.Run(()=>_server.StartServer());
        }

        private void Main_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Control control = (Control)sender;
          
            this.Dispatcher.Invoke(()=> { ChangeMain(); });
            
            Debug.Write(" Heigh:"+this.Height+" Width:"+this.Width+"\n");
        }
        public void ChangeMain()
        {
            Task.Run(() => this.Dispatcher.Invoke(() => {
                MainGrid.Height = this.Height;
                SideMenu.Height = this.Height;
            }));
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
          
        }
        public void MouseMoves()
        {
            ProcessCheckStatus.CheckUserExit.Enabled = ProcessCheckStatus.data.UserFroceTiming;
            if (ProcessCheckStatus.data.UserFroceTiming)
            {
                ProcessCheckStatus.UserControl = true;
            }
        }

        private void Main_StateChanged(object sender, EventArgs e)
        {
            Task.Run(() => this.Dispatcher.Invoke(() => {
                MainGrid.Height = this.Height;
                SideMenu.Height = this.Height;

            }));
        }
    }
}
