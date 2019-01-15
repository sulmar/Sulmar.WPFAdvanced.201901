using Frameworks.MVVMLightDemo.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Frameworks.MVVMLightDemo.Converters
{
    public class MouseButtonEventArgsToLocationConverter : IEventArgsConverter
    {
        public object Convert(object value, object parameter)
        {
            MouseButtonEventArgs e = value as MouseButtonEventArgs;

            Button button = e.Source as Button;
            // Point point = e.GetPosition(button);

            // względem okna
            Point point = e.GetPosition(null);

            return new Location { Latitude = point.X, Longitude = point.Y };
        }

    }
}
