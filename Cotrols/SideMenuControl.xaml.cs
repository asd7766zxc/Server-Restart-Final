using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Server_Restart_Final
{
    /// <summary>
    /// SideMenuControl.xaml 的互動邏輯
    /// </summary>
    public partial class SideMenuControl : UserControl
    {

        public SideMenuControl s;
        public DispatcherTimer dt;
        public ICommand CPMenu;
        public Button _SideMenuBtn;
        public SideMenuControl()
        {
            dt = new DispatcherTimer();
            dt.Tick += Dt_Tick;
            dt.Interval = TimeSpan.FromMilliseconds(10);
            dt.Start();

            CPMenu = new RelayCommand(Global.GlobalSigh.ChangeSideMenu);
            InitializeComponent();

            das.From = 60;
            das.To = 140;
            das.Duration = new Duration(TimeSpan.FromMilliseconds(100));

            da.From = 140;
            da.To = 60;
            da.Duration = new Duration(TimeSpan.FromMilliseconds(50));

            sb.Children.Add(da);
            sbs.Children.Add(das);
            Storyboard.SetTargetName(da,this.Name);
            Storyboard.SetTargetName(das, this.Name);
            Storyboard.SetTargetProperty(da,new PropertyPath(SideMenuControl.WidthProperty));
            Storyboard.SetTargetProperty(das, new PropertyPath(SideMenuControl.WidthProperty));
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
           
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Global.GlobalSigh.ChangeSideMenu();
        }

        DoubleAnimation da = new DoubleAnimation();
        DoubleAnimation das = new DoubleAnimation();
        Storyboard sb = new Storyboard();
        Storyboard sbs = new Storyboard();
        private void SMUC_MouseEnter(object sender, MouseEventArgs e)
        {          
            if (!mouseOn)
            {
                sbs.Begin(this);
                mouseOn = true;
            }
        }

        public bool mouseOn = false;
        private void SMUC_MouseLeave(object sender, MouseEventArgs e)
        {
            if (mouseOn)
            {
                sb.Begin(this);
                mouseOn = false;
            }
        }
    }
}
