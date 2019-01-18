using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace Sulmar.WPF.Advanced.WPFClient.CustomControls
{

    public class MyVisualHost : FrameworkElement
    {        
        private VisualCollection children;

        // private System.Timers.Timer timer;
        DispatcherTimer timer;

        private double x = 100;
        private double y = 100;

        public MyVisualHost()
        {
            children = new VisualCollection(this);
            // timer = new System.Timers.Timer(TimeSpan.FromSeconds(5).TotalMilliseconds);

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += Timer_Tick;

            // timer.Elapsed += Timer_Elapsed;

          //  children.Add(GetLines());

            timer.Start();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {            
            children.Add(GetLines(x+=10, y+10));
        }

        //private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    children.Add(GetLines(++x, ++y));
        //}

        private DrawingVisual GetLines(double x = 100, double y = 100)
        {
            DrawingVisual drawingVisual = new DrawingVisual();

            Pen pen = new Pen(Brushes.Black, 1);

            using (DrawingContext context = drawingVisual.RenderOpen())
            {
                context.DrawLine(pen, new Point(0, 0), new Point(x, y));
                context.DrawLine(pen, new Point(0, y), new Point(x, 0));                
            }

            return drawingVisual;
        }

        protected override int VisualChildrenCount => children.Count;
        protected override Visual GetVisualChild(int index) => children[index];

    }
}
