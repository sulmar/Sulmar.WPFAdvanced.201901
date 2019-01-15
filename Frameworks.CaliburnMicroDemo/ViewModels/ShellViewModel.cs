using Caliburn.Micro;
using Frameworks.CaliburnMicroDemo.IServices;
using Frameworks.CaliburnMicroDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.CaliburnMicroDemo.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly ICustomersService customersService;

        public Customer SelectedCustomer { get; set; }

        public string Name { get; set; }

        public ShellViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            SelectedCustomer = new Customer();
        }

        public void ShowCustomers()
        {

        }

        public bool CanShowCustomers => true;

    }

    public abstract class ViewModelBase : PropertyChangedBase
    {

    }
}
