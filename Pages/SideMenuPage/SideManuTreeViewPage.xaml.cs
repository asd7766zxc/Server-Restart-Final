﻿using System;
using System.Collections.Generic;
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
            foreach (var val in Directory.GetDirectories(ProcessCheckStatus.data.ServerFileLocation))
            {
                var item = new TreeViewItem()
                {
                    Header = val,
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
    }
}
