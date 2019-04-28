using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final
{
    public static  class ReTranslate
    {
        public static string TranslateHost(string host)
        {
            var IPs = Dns.GetHostAddresses(host);
            IPAddress IP = IPs.Where(x => x.AddressFamily == AddressFamily.InterNetwork).FirstOrDefault();
            return IP.ToString();
        }
    }
}
