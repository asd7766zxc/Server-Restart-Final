﻿using System;
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

namespace Server_Restart_Final
{
    /// <summary>
    /// TopMenuControl.xaml 的互動邏輯
    /// </summary>
    public partial class TopMenuControl : UserControl
    {
        public string UpdateImageSource { get { return "/Images/icons8-external-link.png"; }  }
        public TopMenuControl()
        {
            InitializeComponent();
            this.Loaded += TopMenuControl_Loaded;
        }

        private void TopMenuControl_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
