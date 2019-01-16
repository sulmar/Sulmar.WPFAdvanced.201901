using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Sulmar.WPF.Advanced.WPFClient.AttachedProperties
{
    public class TextBoxEx : TextBox
    {

        public object HeaderContent
        {
            get { return (object)GetValue(HeaderContentProperty); }
            set { SetValue(HeaderContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HeaderContent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HeaderContentProperty =
            DependencyProperty.Register("HeaderContent", typeof(object), typeof(TextBoxEx), new PropertyMetadata(null));


    }

    public class Ex
    {
        
        public static readonly DependencyProperty HeaderContentProperty
            = DependencyProperty.RegisterAttached("HeaderContent", 
                typeof(string), 
                typeof(Ex), 
                new PropertyMetadata(default(string)));


        public static string GetHeaderContent(DependencyObject d)
        {
            return (string) d.GetValue(HeaderContentProperty);
        }

        public static void SetHeaderContent(DependencyObject d, string value)
        {
            
               d.SetValue(HeaderContentProperty, value);
            
        }
    }
}
