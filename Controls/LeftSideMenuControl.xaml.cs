using Server_Restart_Final.Pages.SideMenuPage;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Server_Restart_Final
{
    /// <summary>
    /// LeftSideMenuControl.xaml 的互動邏輯
    /// </summary>
    public partial class LeftSideMenuControl : UserControl
    {
        public LeftSideMenuControl()
        {
            
            InitializeComponent();
            this.Loaded += LeftSideMenuControl_Loaded;
          
        }

        private void LeftSideMenuControl_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
        public SideManuTreeViewPage SMTVP = new SideManuTreeViewPage();
        public SideMenuPerformace SMP = new SideMenuPerformace();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.PageContent.Content = SMTVP;
            Maincanvas.Visibility ^= Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.PageContent.Content = SMP;
            Maincanvas.Visibility ^= Visibility.Collapsed;
        }
    }
}
