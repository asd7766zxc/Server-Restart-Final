﻿using System;
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
            Items = new TopMenuItemViewModel
            { 
                  ImageSource =""
                
            };
        }
    }
}