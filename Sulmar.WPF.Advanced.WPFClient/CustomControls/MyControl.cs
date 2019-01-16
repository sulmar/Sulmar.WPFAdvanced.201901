using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sulmar.WPF.Advanced.WPFClient.CustomControls
{
    public class MyControl : Control
    {
        // public double Area { get; set; }
        public double Area
        {
            get { return (double)GetValue(AreaProperty); }
            set { SetValue(AreaProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Area.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AreaProperty =
            DependencyProperty.Register(nameof(Area), typeof(double), typeof(MyControl), 
                new PropertyMetadata(0d));




        public MyControl()
        {
            DefaultStyleKey = typeof(MyControl);
        }


    }
}
