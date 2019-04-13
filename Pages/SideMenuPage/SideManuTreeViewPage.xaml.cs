using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
    /// SideManuTreeViewPage.xaml 的互動邏輯
    /// </summary>
    public partial class SideManuTreeViewPage : Page
    {
        public SideManuTreeViewPage()
        {
            InitializeComponent();
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (!Directory.Exists(ProcessCheckStatus.data.ServerFileLocation)) return;
            foreach (var val in Directory.GetDirectories(ProcessCheckStatus.data.ServerFileLocationFloder))
            {

                var item = new TreeViewItem()
                {
                    Header = val.Remove(0, ProcessCheckStatus.data.ServerFileLocationFloder.Length),
                    Tag = val
                };

                item.Items.Add(null);

                item.Expanded += Folder_Expanded;

                ServerItemViewer.Items.Add(item);
            }

        }

        private void Folder_Expanded(object sender, RoutedEventArgs e)
        {

            var item = (TreeViewItem)sender;
            if (item.Items.Count != 1 || item.Items[0] != null)
                return;

            item.Items.Clear();

            var FP = (string)item.Tag;
            var DS = new List<string>();
            try
            {
                var VP = Directory.GetDirectories(FP);
                if (VP.Length > 0)
                {
                    DS.AddRange(VP);
                }
            }
            catch
            { }
            DS.ForEach(directoryPath =>
            {
                var SubItem = new TreeViewItem()
                {
                    Header = GFN(directoryPath),
                    Tag = directoryPath
                };

                SubItem.Items.Add(null);
                SubItem.Expanded += Folder_Expanded;
                item.Items.Add(SubItem);
            });



            var file = new List<string>();
            try
            {
                var fs = Directory.GetFiles(FP);
                if (fs.Length > 0)
                {
                    file.AddRange(fs);
                }
            }
            catch
            { }
            file.ForEach(FilePath =>
            {
                var SubItem = new TreeViewItem()
                {
                    Header = GFN(FilePath),
                    Tag = FilePath
                };
                item.Items.Add(SubItem);
            });
        }

        public static string GFN(string s)
        {
            if (string.IsNullOrEmpty(s))
                return String.Empty;
            var NP = s.Replace('/', '\\');
            var LI = NP.LastIndexOf('\\');
            if (LI <= 0)
                return s;
            return s.Substring(LI + 1);
        }
        public SideFloatWindowControl SideFW = new SideFloatWindowControl();
        private void StackPanel_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (ServerItemViewer.SelectedItem == null)
                return;

            var PosY = e.GetPosition(this).Y;
            var PosX = e.GetPosition(this).X;
            int MainHeight = (int)this.ActualHeight;
            int MainWidth = (int)this.ActualWidth;
            var MarginHeight = MainHeight - (PosY);
            var MarginWidth = MainWidth - (PosX);

            this.MainGrid.Children.Remove(SideFW);
        
            this.MainGrid.Children.Add(SideFW);
            Grid.SetRow(SideFW, 1);
            SideFW.Margin = new Thickness(PosX-150 , PosY-30 , MarginWidth, MarginHeight-150);

            SideFW.Focusable = true;
            SideFW.IsEnabled = true;

            SideFW.LostFocus += SideFW_LostFocus;
            SideFW.Loaded += SideFW_Loaded;
            this.LostFocus += SideManuTreeViewPage_LostFocus;
        }

        private void SideManuTreeViewPage_LostFocus(object sender, RoutedEventArgs e)
        {
           
        }

        private void SideFW_Loaded(object sender, RoutedEventArgs e)
        {
            SideFW.Focus();
        }

        private void SideFW_LostFocus(object sender, RoutedEventArgs e)
        {
            this.MainGrid.Children.Remove(SideFW);
        }

        private void StackPanel_LostFocus(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
