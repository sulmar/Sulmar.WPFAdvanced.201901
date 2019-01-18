using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Sulmar.WPF.Advanced.WPFClient.CustomControls
{
    public class Strange : FrameworkElement
    {
        DispatcherTimer timer;

        private double x = 100;
        private double y = 100;

        public Color Color
        {
            get { return (Color)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Color.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorProperty =
            DependencyProperty.Register("Color", 
                typeof(Color), 
                typeof(Strange), 
                new FrameworkPropertyMetadata(Colors.Red, FrameworkPropertyMetadataOptions.AffectsRender));

        public Strange()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += (t, s) => this.InvalidateVisual();
            timer.Start();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            x += 10;
            y += 10;

            Pen pen = new Pen(new SolidColorBrush(Color), 1);

            drawingContext.DrawLine(pen, new Point(0, 0), new Point(x, y));
            drawingContext.DrawLine(pen, new Point(0, y), new Point(x, 0));

            //BitmapImage bitmapImage = new BitmapImage();
            //bitmapImage.BeginInit();
            //Stream stream = new MemoryStream();
            //bitmapImage.StreamSource = stream;
            //bitmapImage.EndInit();
            //bitmapImage.Freeze();
            //drawingContext.DrawImage(bitmapImage, new Rect(RenderSize));

            //drawingContext.DrawImage()

            base.OnRender(drawingContext);

            

            
        }

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

    }
}
