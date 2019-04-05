using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Server_Restart_Final.Pages
{
    /// <summary>
    /// Particle.xaml 的互動邏輯
    /// </summary>
    public partial class Particles : Page
    {
        List<System.Windows.Shapes.Rectangle> recs = new List<System.Windows.Shapes.Rectangle>();
        public Particles()
        {
            this.Loaded += Particle_Loaded;
            InitializeComponent();
        }

        private void Particle_Loaded(object sender, RoutedEventArgs e)
        {
          
         
        
           
        }
    }
}
