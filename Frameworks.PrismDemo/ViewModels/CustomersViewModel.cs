using Frameworks.PrismDemo.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.PrismDemo.ViewModels
{
    public class CustomersViewModel
    {
        private readonly ICustomersService customersService;

        public CustomersViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;
        }
    }
}
