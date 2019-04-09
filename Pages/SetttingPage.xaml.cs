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
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using Server_Restart_Final.DataStorage;
using System.Windows.Threading;
using System.Text.RegularExpressions;
using MessageBox = System.Windows.MessageBox;

namespace Server_Restart_Final
{
    /// <summary>
    /// SetttingPage.xaml 的互動邏輯
    /// </summary>
    public partial class SetttingPage : Page
    {
        List<Commands> od_command = new List<Commands>();
        DispatcherTimer Dt = new DispatcherTimer();
        public SetttingPage()
        {
            Dt.Tick += Dt_Tick;
            Dt.Interval = TimeSpan.FromSeconds(1);
            this.Unloaded += SetttingPage_Unloaded;
            Dt.Start();
            InitializeComponent();
           
        }

        private void SetttingPage_Unloaded(object sender, RoutedEventArgs e)
        {
           for(int i = CommandEditList.Items.Count-1; i>-1;i--)
            CommandEditList.Items.RemoveAt(i);

            od_command = null;
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            UIRefresh.Refreshs(CommandEditList);
        }
        
        public string ServerFileName = "";
        public string ServerFilePath = "";
        public string ServerFileFloder = "";
        public bool USerForCe = false;
        private void OpenFilePicker_Btn_Click(object sender, RoutedEventArgs e)
        {
            ServerFilePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Batch|*.bat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var ServerFile = ofd.FileName;
                var ServerFiles = ServerFile.Split('\\');
                Settingsa.Content = ServerFiles[ServerFiles.Length - 1];
                ServerFileName = ServerFile;
                for (int i = 0; i < ServerFiles.Length - 1; i++)
                {
                    ServerFilePath += ServerFiles[i] + "\\";
                }
                for (int i = 0; i < ServerFiles.Length - 2; i++)
                {
                    ServerFileFloder += ServerFiles[i] + "\\";
                }
            }
        }

        private void SaveFilePicker_Btn_Click(object sender, RoutedEventArgs e)
        {
            ProcessCheckStatus.data.command = command;
            ProcessCheckStatus.data.ServerFileLocationFloder = ServerFileFloder;
            ProcessCheckStatus.data.Memory = ValueSearch.Text;
            ProcessCheckStatus.data.parameter = parameter.Text;
            ProcessCheckStatus.data.ServerRestartTimes = int.Parse(ServerRestartTimes.Text);
            ProcessCheckStatus.data.ServerFileLocationName = ServerFileName;
            ProcessCheckStatus.data.UserFroceTiming = UserFroceCheck.IsChecked.Value;
            ProcessCheckStatus.data.ServerFileLocation = ServerFilePath;
            ProcessCheckStatus.data.SQLServerLoaction = SQLServerLocation.Text;
            StorageData.SaveData(ProcessCheckStatus.data, System.Windows.Forms.Application.StartupPath + "\\LocalData.xml");
            StorageBatch.Batch.SaveBatch(ProcessCheckStatus.data.parameter);
            UpdatePage();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           
            ProcessCheckStatus.data = StorageData.FromXmlFile<Data>(System.Windows.Forms.Application.StartupPath + "\\LocalData.xml");
            command = ProcessCheckStatus.data.command;
            od_command = command;
            Settings.Content = "伺服器批次檔:  " + ProcessCheckStatus.data.ServerFileLocationName + "\n" + "伺服器位置:  " + ProcessCheckStatus.data.ServerFileLocation + "\n" + "伺服器資料夾:  " + ProcessCheckStatus.data.ServerFileLocationFloder  + "\n" + "使用者停滯自動掌管:  " + ProcessCheckStatus.data.UserFroceTiming + "\n" + "Server Crash Report - Server:  " + ProcessCheckStatus.data.SQLServerLoaction + "\n" + "RestartTimes: " + ProcessCheckStatus.data.ServerRestartTimes;
            ValueSearch.Text = ProcessCheckStatus.data.Memory;
            odMemory = ProcessCheckStatus.data.Memory;
            UserFroceCheck.IsChecked = ProcessCheckStatus.data.UserFroceTiming;
            SQLServerLocation.Text = ProcessCheckStatus.data.SQLServerLoaction;
            ServerRestartTimes.Text = ProcessCheckStatus.data.ServerRestartTimes.ToString();
            ServerFileName = ProcessCheckStatus.data.ServerFileLocationName;
            ServerFilePath = ProcessCheckStatus.data.ServerFileLocation;
            parameter.Text = ProcessCheckStatus.data.parameter;

            if(File.Exists(ProcessCheckStatus.data.ServerFileLocationName))
                parameter.Text = StorageBatch.Batch.LoadBatch();

            foreach (var item in od_command)
            {
                CommandEditList.Items.Add(item);
            }
        }
        public void UpdatePage()
        {
            ProcessCheckStatus.data = StorageData.FromXmlFile<Data>(System.Windows.Forms.Application.StartupPath + "\\LocalData.xml");
            Settings.Content = "伺服器批次檔:  " + ProcessCheckStatus.data.ServerFileLocationName + "\n" + "伺服器位置:  " + ProcessCheckStatus.data.ServerFileLocation + "\n" + "伺服器資料夾:  " + ProcessCheckStatus.data.ServerFileLocationFloder + "\n" + "使用者停滯自動掌管:  " + ProcessCheckStatus.data.UserFroceTiming + "\n" + "Server Crash Report - Server:  " + ProcessCheckStatus.data.SQLServerLoaction + "\n" + "RestartTimes: " + ProcessCheckStatus.data.ServerRestartTimes;
        }

        private void SQLServerLocation_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
        List<Commands> command = new List<Commands>();
        private void CommandEdit_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AddItem();
            }
        }


        private void MemorySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var cp = parameter.Text.Split(' ');
            var outp = "";
            int outm = (int)(MemorySlider.Value * 3200);
            foreach (var rp in cp)
            {
              
                if (rp == ValueSearch.Text)
                {

                    ValueSearch.Text = "-Xmx" + outm + "M";
                    outp += "-Xmx"+outm+"M ";
                    odMemory = "-Xmx" + outm + "M";
                }
                else
                {
                  outp += $"{rp} ";
                }
            }
            parameter.Text = outp;
        }

        private void Parameter_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            ProcessCheckStatus.data.parameter = parameter.Text;
        }
        public string odMemory;
        private void ValueSearch_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var cp = parameter.Text.Split(' ');
                var outp = "";
                foreach (var rp in cp)
                {
                    if (rp == odMemory)
                    {
                        outp += ""+ValueSearch.Text+" ";
                        odMemory =ValueSearch.Text;
                    }
                    else
                    {
                        outp += $"{rp} ";
                    }
                }
                parameter.Text = outp;
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            RemoveItem();
        }
        public void RemoveItem()
        {
            if (CommandEditList.SelectedIndex < 0) return;
            CommandEditList.Items.RemoveAt(CommandEditList.SelectedIndex);
            od_command.RemoveAt(CommandEditList.SelectedIndex + 1);
            command = od_command;
        }
        public void AddItem()
        {
            od_command.Add(new Commands() { command = CommandEdit.Text, commandindex = int.Parse(CommandEditNum.Text) });
            CommandEditList.Items.Add(new Commands() { command = CommandEdit.Text, commandindex = int.Parse(CommandEditNum.Text) });
            CommandEdit.Text = "";
            command = od_command;
        }
    }
    public class Commands
    {
        public string command { get; set; }
        public int commandindex { get; set; }
    }
    public static class UIRefresh
    {
        public static Action ED = delegate () { };
        public static void Refreshs(UIElement ue)
        {
            ue.Dispatcher.Invoke(DispatcherPriority.Render, ED);
        }
    }
}
