using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Controls;
using Timer = System.Timers.Timer;

namespace Server_Restart_Final.Event_Handler
{
    public class Server_UI_Update_Event_Handler:Basic_Handler
    {
        public Timer Refresh;
        public string OutPutText;
        string buffer;
        public TextBox OutPutTextBox;
        public MainPage Mp;
        Action<object> _ac;
        public Server_UI_Update_Event_Handler(MainPage mp,Task updatetask,string TaskName)
        {
            
            Refresh = new Timer
            {
                Interval = 1,
                Enabled=false,
                AutoReset = true,
            };
            Refresh.Elapsed += Refresh_Elapsed;
            Mp = mp;
            this.OutPutTextBox = Mp.OutPut;
            _ac = (object obj) => { Mp.Dispatcher.Invoke(() => { OutPutTextBox.Text=OutPutText; OutPutTextBox.ScrollToEnd(); }); };
        }

        private void Refresh_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (OutPutText != buffer)
            {
                _ac(OutPutText);
                buffer = OutPutText;
            }
        }
        object RefreshCheck=true;
        override public void UpdateUI(string e)
        {
            Mp.Dispatcher.Invoke(() => { OutPutTextBox.AppendText(e + "\n"); OutPutTextBox.ScrollToEnd(); }); 
            Refresh.Enabled = false;
        }
       
    }
}
