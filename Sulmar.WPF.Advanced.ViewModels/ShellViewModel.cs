using Sulmar.WPF.Advanced.Common;
using System;
using System.Windows.Input;

namespace Sulmar.WPF.Advanced.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;


        public ICommand ShowCustomersCommand { get; }
        public ICommand ShowDepartmentsCommand { get; set; }

        public ShellViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            ShowCustomersCommand = new RelayCommand(ShowCustomers);
            ShowDepartmentsCommand = new RelayCommand(()=>navigationService.Navigate("DepartmentsView"));
        }

        private void ShowCustomers() => navigationService.Navigate("CustomersView");
    }
}
