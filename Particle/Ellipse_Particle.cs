using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Server_Restart_Final
{
    public class Ellipse_Particle
    {
        public Ellipse cir;
        public Canvas main;
        public Ellipse_Particle(Canvas _m)
        {
            main = _m;
        }
        public void Draw()
        {
            cir = new Ellipse();
            cir.StrokeThickness = 10;
            cir.Stroke = Brushes.AliceBlue;
            cir.Height = 10;
            cir.Width = 10;
            Move_Control();
            main.Children.Add(cir);
        }
        Random r = new Random();
        SolidColorBrush b;
        public async Task Move_Control()
        {
            Point MousePoint = new Point(r.Next(0,(int)Application.Current.MainWindow.Width), Application.Current.MainWindow.Height);
            var PosX = (int)(MousePoint.X - (cir.Width / 2));
            var PosY = (int)(MousePoint.Y - (cir.Height / 2));

            int MainHeight = (int)main.Height;
            int MainWidth = (int)main.Width;
            var MarginHeight = MainHeight - (PosY + (int)SystemParameters.CaptionHeight + (int)SystemParameters.BorderWidth + 4);
            var MarginWidth = MainWidth - (PosX + (int)SystemParameters.BorderWidth);
            cir.Margin = new Thickness(PosX, PosY, MarginWidth, MarginHeight);
            for (int i = 0; i <= 1000; i+=999)
            {
                    await Task.Delay(1);
                    cir.Margin = new Thickness(PosX, PosY - i, MarginWidth, MarginHeight + i);
                
                    b = new SolidColorBrush(Color.FromArgb((byte)i,255,255,255));
                    cir.Stroke = b;
            }
            cir.Stroke = Brushes.Transparent;
            cir = null;

        }
    }
}
