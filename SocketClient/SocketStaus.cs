using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server_Restart_Final.SocketClient;

namespace Server_Restart_Final
{
    public class SocketStaus
    {
        public TransferClient transferClient;
        private Listener listeners;
        private string outputfolder;
        private Timer tmrOverallprog;
        public string HostName { get; set; }
        public int Port { get; set; }
        public bool Enbled { get; set; }
        public bool Connected { get; set; }
        public bool serverRunning { get; set; }
        public SocketStaus(string hostname,int port)
        {
            HostName = hostname;
            Port = port;
            listeners = new Listener();
            listeners.Accepted += Listener_Accepted;
            tmrOverallprog = new Timer();
            tmrOverallprog.Interval = 1000;
            tmrOverallprog.Tick += TmrOverallprog_Tick;

            outputfolder = "Transfers";
            if (!Directory.Exists(outputfolder))
                Directory.CreateDirectory(outputfolder);
        }
        public void StartServer(int Port)
        {
            if (serverRunning)
                return;
            serverRunning = true;
            try
            {
                listeners.Start(Port);
                setConnetionStaus("Waiting...");
            }
            catch
            {

            }
        }
        public void OnApplicationClosing()
        {
            DeregisterEvents();
        }
        public void StopServer()
        {
            if (!serverRunning)
                return;
            if (transferClient != null)
                transferClient.Close();
            listeners.Stop();
            tmrOverallprog.Stop();
            setConnetionStaus("--");
            serverRunning = false;
        }
        public void ConnectToServer()
        {
            if (transferClient == null)
            {
                transferClient = new TransferClient();
                transferClient.Connect(HostName,Port,connectCallBack);
                Enbled = false;
                Connected = true;
            }
            else
            {
                transferClient.Close();
                transferClient = null;
                Connected = false;
            }
        }
        public void connectCallBack(object sender, string error)
        {
            Enbled = true;
            if (error != null)
            {
                transferClient.Close();
                transferClient = null;
                return;
            }
            RegisterEvents();
            transferClient.OutputFolder = outputfolder;
            transferClient.Run();
            setConnetionStaus(transferClient.EndPoint.Address.ToString());
            tmrOverallprog.Start();
            setConnetionStaus("Connecting...");
            //TODO:Refresh UI
        }
        public void RegisterEvents()
        {
            transferClient.Complete += TransferClient_Complete;
            transferClient.Disconnected += TransferClient_Disconnected;
            transferClient.ProgressChanged += TransferClient_ProgressChanged;
            transferClient.Queued += TransferClient_Queued;
            transferClient.Stopped += TransferClient_Stopped;
        }
        public void setConnetionStaus(string address)
        {
            Global.GlobalSigh.UpdateConnectStaus(address);
            Debug.Print(address);
        }
        public void SendFile(string filename)
        {
            if (transferClient == null)
                return;

            transferClient.QueueTransfer(filename);
        }
        public void PauseTransfer()
        {
            if (transferClient == null)
                return;

            foreach (TransferQueue queue in Global.GlobalSigh.LisOfQueue)
            {
                queue.Client.PauseTransfer(queue);
            }
        }

        public void StopTransfer()
        {
            if (transferClient == null)
                return;

            foreach (TransferQueue queue in Global.GlobalSigh.LisOfQueue)
            {
                queue.Client.StopTransfer(queue);
                Global.GlobalSigh.LisOfQueue.Remove(queue);
            }
            Global.GlobalSigh.TranserValueProgress = 0;
        }

        public void ClearComplete()
        {
            foreach (TransferQueue queue in Global.GlobalSigh.LisOfQueue)
            {
                if (queue.Progress == 100 || !queue.Running)
                {
                    Global.GlobalSigh.LisOfQueue.Remove(queue);
                }
            }
        }
        private void TransferClient_Stopped(object sender, TransferQueue queue)
        {
            Global.GlobalSigh.LisOfQueue = new List<TransferQueue>();
        }

        private void TransferClient_Queued(object sender, TransferQueue queue)
        {
            Global.GlobalSigh.TransferUpdate(queue.ID.ToString(), queue.FileName, queue.Type == QueueType.Download ? "Download":"Upload","0%");
            Global.GlobalSigh.LisOfQueue.Add(queue);
            if (queue.Type == QueueType.Download)
            {
                transferClient.StartTransfer(queue);
            }
        }

        private void TransferClient_ProgressChanged(object sender, TransferQueue queue)
        {
            Global.GlobalSigh.TranserValueProgress = queue.Progress;
        }

        private void TransferClient_Disconnected(object sender, EventArgs e)
        {
            DeregisterEvents();
            try
            {
                foreach (TransferQueue aqueue in Global.GlobalSigh.LisOfQueue)
                {
                    aqueue.Close();
                    Global.GlobalSigh.LisOfQueue.Remove(aqueue);
                }
            }
            catch { }
            Global.GlobalSigh.LisOfQueue = new List<TransferQueue>();

            transferClient = null;
            setConnetionStaus("null");
            if (serverRunning)
            {
                listeners.Start(Port);
                setConnetionStaus("await");
            }
        }

        private void TransferClient_Complete(object sender, TransferQueue queue)
        {
            Global.GlobalSigh.SendComplete("Complete");
        }

        public void DeregisterEvents()
        {
            if (transferClient == null)
                return;

            transferClient.Complete -= TransferClient_Complete;
            transferClient.Disconnected -= TransferClient_Disconnected;
            transferClient.ProgressChanged -= TransferClient_ProgressChanged;
            transferClient.Queued -= TransferClient_Queued;
            transferClient.Stopped -= TransferClient_Stopped;
        }
        private void TmrOverallprog_Tick(object sender, EventArgs e)
        {
            if (transferClient == null)
                return;

            Global.GlobalSigh.TranserValueProgress = transferClient.GetOverallProgress();
        }

        private void Listener_Accepted(object sender, SocketAcceptedEventArgs e)
        {
            listeners.Stop();
            transferClient = new TransferClient(e.Accepted);
            transferClient.OutputFolder = outputfolder;
            RegisterEvents();
            transferClient.Run();
            tmrOverallprog.Start();
            setConnetionStaus(transferClient.EndPoint.Address.ToString());
        }
    }
}

