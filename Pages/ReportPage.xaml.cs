using Server_Restart_Final.SocketClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Server_Restart_Final
{
    /// <summary>
    /// ReportPage.xaml 的互動邏輯
    /// </summary>
    public partial class ReportPage : Page
    {

       
        public ReportPage()
        {
            InitializeComponent();
            this.Loaded += ReportPage_Loaded;
          
        }

        private void TmrOverallprog_Tick(object sender, EventArgs e)
        {

        }

        private void Listener_Accepted(object sender, SocketAcceptedEventArgs e)
        {
        
        }

        private void ReportPage_Loaded(object sender, RoutedEventArgs e)
        {
            Global.GlobalSigh.reports = this.MainRP;
            Global.GlobalSigh.reportst = this.RPT;
        }
    }
}
