using Sulmar.WPF.Advanced.Common;
using System;
using System.Windows.Input;

namespace Sulmar.WPF.Advanced.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;


        public ICommand ShowCustomersCommand { get; private set; }

        public ShellViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            ShowCustomersCommand = new RelayCommand(ShowCustomers);
        }

        private void ShowCustomers() => navigationService.Navigate("CustomersView");
    }
}
