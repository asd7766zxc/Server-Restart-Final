using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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
using System.Windows.Threading;

namespace Server_Restart_Final.Pages.SideMenuPage
{
    /// <summary>
    /// SideMenuPerformace.xaml 的互動邏輯
    /// </summary>
    public partial class SideMenuPerformace : Page
    {
        List<RectangleGeometry> ListPerformance = new List<RectangleGeometry>();
        DispatcherTimer UpdateServerPerformance = new DispatcherTimer();
        PathSegmentCollection CollectSegment = new PathSegmentCollection();
        PathFigureCollection CollectFigure = new PathFigureCollection();
        PathGeometry GeometryPath = new PathGeometry();
        GeometryCollection gc = new GeometryCollection();
        public SideMenuPerformace()
        {
            InitializeComponent();
            UpdateServerPerformance.Interval = TimeSpan.FromSeconds(0.1);
            UpdateServerPerformance.Tick += UpdateServerPerformance_Tick;
           
            this.Loaded += SideMenuPerformace_Loaded;
            this.Unloaded += SideMenuPerformace_Unloaded;
        }

        private void SideMenuPerformace_Unloaded(object sender, RoutedEventArgs e)
        {
            UpdateServerPerformance.Stop();
        }

        private void SideMenuPerformace_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateServerPerformance.Start();
        }

        int movensum = 0;
        int tilesum = 0;
        private void UpdateServerPerformance_Tick(object sender, EventArgs e)
        {
            var rec = new Rect();
            try
            {
                movensum += 5;
                if (ListPerformance.Count >= this.ActualWidth)
                {
                    tilesum++;
                    PerformaceStartPoint1.Figures[tilesum].Segments.RemoveAt(tilesum);
                }
                Out.Content = $"本機運作時間 - {Environment.TickCount/1000/60/60} : {(Environment.TickCount / 1000 / 60)-((Environment.TickCount / 1000 / 60 / 60)*60)} : {(Environment.TickCount/1000) - ((Environment.TickCount / 1000 / 60 ) *60)}";
                Out1.Content = $"記憶體使用量 - {Environment.WorkingSet / 1024 / 1024/2}MB";
                this.PerformaceStartPoint1.AddGeometry(new RectangleGeometry(new Rect(movensum, (Environment.WorkingSet / 1024 / 1024 /2), 5, Environment.WorkingSet / 1024 / 1024)));
                MainPath.Margin = new Thickness(0, 0, 100, 0);
            }
            catch
            {
            }
        }
    }
}
