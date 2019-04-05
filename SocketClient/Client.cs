using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server_Restart_Final.SocketClient
{
    public class Client
    {
        public Socket MainClient { get; set; }
        public NetworkStream ns { get; set; }
        
        public Client()
        {
            MainClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Connect(string ip,int port)
        {
            if (String.IsNullOrEmpty(ip)) return;
            var IPs = Dns.GetHostAddresses(ip);
            IPAddress IP = IPs.Where(x=>x.AddressFamily==AddressFamily.InterNetwork).FirstOrDefault();
            var ep = new IPEndPoint(IP, port);
            try
            {
                MainClient.Connect(ep);
            }
            catch
            {
                return;
            }
            ns = new NetworkStream(MainClient);
            Thread thread = new Thread(o => ReceiveData((Socket)o));
            thread.Start(MainClient);
        }
        static void ReceiveData(Socket client)
        {
            string g="";
            NetworkStream ns = new NetworkStream(client);
            byte[] receivedBytes = new byte[1024];
            int byte_count;
            try
            {
                while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
                {
                    g = Encoding.UTF8.GetString(receivedBytes, 0, byte_count);
                    Global.GlobalSigh.mp.Dispatcher.Invoke(() => {
                        Global.GlobalSigh.IoCOut.AppendText(g + "\n");
                        Logger.Log(DateTime.Now+"IoC: "+ g+"\n");
                    });
                    var command = g.Split('|');
                    switch (command[0])
                    {
                        case "restart":
                          ProcessCheckStatus.CommandRestartServer();
                            break;
                        case "start":
                            break;
                        case "close":
                            break;
                        case "Get":
                            GetSetFile.GetFile(command[1]);
                            break;
                        case "Set":
                            break;
                        case "CopyTo":
                            GetSetFile.SetFile(command[1]);
                            break;
                        case "GD":
                            GetSetFile.GetFloder(command[1]);
                            break;
                    }
                }
            }
            catch { }
        }
       
        public async Task Send(byte[] buffer)
        {
            byte[] Buffer = buffer;
            await ns.WriteAsync(Buffer, 0, Buffer.Length);
            await Task.CompletedTask;
        }
    }
}
