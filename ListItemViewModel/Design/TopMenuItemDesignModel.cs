using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final
{
   public class TopMenuItemDesignModel:TopMenuItemViewModel
    {
        public static TopMenuItemDesignModel HalfInstance
        => new TopMenuItemDesignModel();

        public TopMenuItemDesignModel()
        {
            ImageSource = "/Images/icons8-server-96.png";
        }
    }
}
