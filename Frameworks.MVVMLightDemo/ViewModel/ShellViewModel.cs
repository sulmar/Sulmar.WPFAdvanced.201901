using Frameworks.MVVMLightDemo.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Frameworks.MVVMLightDemo.ViewModel
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;

        public ICommand ShowCustomersCommand { get; }
        public ICommand FireCommand { get; }

        public ShellViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            
           ShowCustomersCommand = new RelayCommand(ShowCustomers);
           FireCommand = new RelayCommand<Location>(Fire);
        }

        private void Fire(Location obj)
        {
            MessageBox.Show($"Fire at {obj.Latitude}:{obj.Longitude}");
        }

        private void ShowCustomers()
        {
            navigationService.NavigateTo("Page2View", "Hello World");
        }
    }
}
