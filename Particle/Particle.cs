using Server_Restart_II;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Color = System.Windows.Media.Color;
using Point = System.Windows.Point;

namespace Server_Restart_Final
{
    class Particle
    {
        private Color ParticleColor = Color.FromRgb(2,2,2);
        private TimeSpan LiveTime = new TimeSpan(0,0,0,1);
        public MouseButtonEventArgs mouse;
        public MainWindow mw;
        private DateTime? BirthTime;
        private Point _Location;
        public Point Location { get { return _Location; }set { _Location = value; }  }
        private Point _Velocity;
        public Point Velocity { get { return _Velocity; } set { _Velocity = value; } }

        public static Random rt = new Random();
        static double num = 0;
        public static Point RandomVector(int speed)
        {
            float rangle = (float)(rt.NextDouble() * (Math.PI * 2));
            speed *= (int)rt.NextDouble();
            return new Point((float)Math.Cos(rangle)*speed, (float)Math.Sin(rangle)*speed);
        }
        public Particle(Point location,int _speed):this(location,RandomVector(_speed))
        {

        }
        public Particle(Point location, Point velocity)
        { 
            _Location = location;
            _Velocity = velocity;
        }
        public bool PerformFrame(ProgramState ps)
        {
            if (BirthTime == null) BirthTime = DateTime.Now;
            _Location = new Point(_Location.X + _Velocity.X, _Location.Y + _Velocity.Y);
            _Velocity = new Point(_Velocity.X * 0.99f, _Velocity.Y * 0.99f);
            return DateTime.Now - BirthTime > LiveTime;
        }
        public Ellipse cir;
        public void Draw(Canvas g)
        {
            Color usecolor = ParticleColor;
            if (BirthTime==null)
            {
                BirthTime =DateTime.Now;
            }
            double mslivetime = (DateTime.Now - BirthTime).Value.TotalMilliseconds;
            double lifetime = LiveTime.TotalMilliseconds;
            double pencentlife = mslivetime / lifetime;
            int Alphause = 255-(int)(pencentlife * 255);
            ParticleColor = Color.FromRgb((byte)rt.Next(200,255), (byte)rt.Next(200,255), (byte)rt.Next(200,255));
            if (Alphause <= 0)
            {
                Alphause = 0;
            }
            cir = new Ellipse();
            cir.Height = 10;
            cir.Width = 10;
            cir.StrokeThickness = 2;
            cir.Stroke = System.Windows.Media.Brushes.AliceBlue;
            Move_Control(g);
            g.Children.Add(cir);
        }
        public void Move_Control(Canvas r)
        {
            var PosX = Location.X;
            var PosY = Location.Y;

            int MainHeight = (int)r.Height;
            int MainWidth = (int)r.Width;
            var MarginHeight = MainHeight - (PosY + (int)cir.Height + (int)SystemParameters.CaptionHeight + (int)SystemParameters.BorderWidth + 4);
            var MarginWidth = MainWidth - (PosX + (int)cir.Width + (int)SystemParameters.BorderWidth);
            cir.Margin = new Thickness(PosX, PosY, MarginWidth, MarginHeight);
        }
    }
}
