using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Batch;
using MPI;

namespace Server_Restart_Final
{
    public class UnitMPI
    {
        Communicator comm = Communicator.world;
        ActionStream As = new ActionStream(ReadFuc,WriteFuc);
        public UnitMPI()
        {
           
        }
      static Func<byte[], int> ReadFuc;

      static Action<byte[]> WriteFuc;
      
    }
}
