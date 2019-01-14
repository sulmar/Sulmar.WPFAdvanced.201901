﻿using Sulmar.WPF.Advanced.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Sulmar.WPF.Advanced.WPF
{
    public class FrameNavigationService : INavigationService
    {
        public object Parameter { get; private set; }

        private Frame frame = null;

        public void GoBack()
        {
            Frame frame = GetFrame("MainFrame");

            frame.GoBack();
        }

        public void GoForward()
        {
            Frame frame = GetFrame("MainFrame");

            frame.GoForward();
        }

        public void Navigate(string viewname, object parameter = null)
        {
            Frame frame = GetFrame("MainFrame");

            Uri uri = new Uri($"Views/{viewname}.xaml", UriKind.Relative);

            frame.Navigate(uri, parameter);
        }

        private Frame GetFrame(string name)
        {
            if (frame != null)
            {
                return frame;
            }
            else
            if (Application.Current.MainWindow.FindName(name) is Frame _frame)
            {
                frame = _frame;                
            }

            return frame;
        }

    } 
    
}
