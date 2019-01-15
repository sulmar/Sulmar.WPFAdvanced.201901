using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Frameworks.PrismDemo.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly IRegionManager regionManager;


        public ICommand ShowCustomersCommand { get;  }

        public ShellViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            ShowCustomersCommand = new DelegateCommand<string>(ShowCustomers);
        }

        private void ShowCustomers(string obj)
        {
            regionManager.RequestNavigate("ContentRegion", "CustomersView");
        }
    }
}
