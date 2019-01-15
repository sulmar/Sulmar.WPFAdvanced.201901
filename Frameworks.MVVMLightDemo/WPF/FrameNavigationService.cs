using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Frameworks.MVVMLightDemo.WPF
{
    public class FrameNavigationService : INavigationService
    {
        public string CurrentPageKey { get; private set; }

        private Frame frame = null;

        public void GoBack()
        {
            Frame frame = GetFrame("MainFrame");
            frame.GoBack();
        }

        public void NavigateTo(string pageKey)
        {
            NavigateTo(pageKey, null);
        }

        private void Navigate(string viewname, object parameter = null)
        {
            Frame frame = GetFrame("MainFrame");

            Uri uri = new Uri($"Views/{viewname}.xaml", UriKind.Relative);

            frame.Navigate(uri, parameter);
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            Navigate(pageKey, parameter);

            CurrentPageKey = pageKey;
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
