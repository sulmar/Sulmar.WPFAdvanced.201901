using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace Sulmar.WPF.Advanced.WPFClient.Converters
{
    public class MyConverter : MarkupExtension,  IValueConverter
    {
        private static MyConverter instance;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Colors.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (instance is null)
            {
                instance = this;
            }

            return instance;
            
        }
    }
}
