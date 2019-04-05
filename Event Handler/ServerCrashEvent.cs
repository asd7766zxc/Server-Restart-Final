using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final.Event_Handler
{
    public class ServerCrashEvent
    {
        public delegate void ServerCrashHandler();
        public event ServerCrashHandler ServerCrashHandle;
        protected virtual void OnServerCrash()
        {
            if (ServerCrashHandle!=null)
            {
                ServerCrashHandle();
            }
        }
        public void CheckServerCrash()
        {
            if (ProcessCheckStatus.ServerClose)
            {
                if (ProcessCheckStatus.ServerCrash)
                {
                    OnServerCrash();
                }
            }  
        }
    }
}
