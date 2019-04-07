using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Restart_Final
{
    public class TopMenuDesignViewModel:TopMenuViewModel
    {
        public static TopMenuDesignViewModel HalfInstance
      => new TopMenuDesignViewModel();
        public TopMenuDesignViewModel()
        {
            items = new TopMenuItemViewModel
            { 
                  ImageSource = "/Images/icons8-flag-2-25.png"

            };
        }
    }
}
