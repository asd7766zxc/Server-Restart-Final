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
        List<LineSegment> ListPerformance = new List<LineSegment>();
        DispatcherTimer UpdateServerPerformance = new DispatcherTimer();
        PathSegmentCollection CollectSegment = new PathSegmentCollection();
        PathFigureCollection CollectFigure = new PathFigureCollection();
        PathGeometry GeometryPath = new PathGeometry();
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
            try
            {
                ListPerformance.Add(new LineSegment());
                ListPerformance[ListPerformance.Count - 1].Point = new Point(movensum, Environment.WorkingSet / 1024 / 1024);
                movensum += 10;
                if (ListPerformance.Count >= this.ActualWidth)
                {
                    tilesum++;
                    CollectSegment.Remove(ListPerformance[tilesum]);
                }
                CollectSegment.Add(ListPerformance[ListPerformance.Count - 1]);
                this.PerformaceStartPoint.Segments = CollectSegment;
                MainPath.Margin = new Thickness(0, 0, 100, 0);
            }
            catch
            {
            }
        }
    }
}
