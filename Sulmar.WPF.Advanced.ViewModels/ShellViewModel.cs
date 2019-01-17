using Sulmar.WPF.Advanced.Common;
using System;
using System.Windows.Input;

namespace Sulmar.WPF.Advanced.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly INavigationService navigationService;

        public ICommand ShowDepartmentsCommand { get; set; }

        public RelayCommand<string> NavigateCommand { get; }

        public ShellViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            ShowDepartmentsCommand = new RelayCommand(()=>navigationService.Navigate("DepartmentsView"));

            NavigateCommand = new RelayCommand<string>(p => navigationService.Navigate(p));

        }

    }
}
