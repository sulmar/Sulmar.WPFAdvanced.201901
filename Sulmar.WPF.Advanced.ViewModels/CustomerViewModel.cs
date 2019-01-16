using Sulmar.WPF.Advanced.IServices;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.ViewModels
{
    public class CustomerViewModel : ViewModelBase
    {
        private readonly ICustomersService customersService;

        public Customer Customer { get; set; }

        public CustomerViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            Load();
        }

        private void Load()
        {
            Customer = customersService.Get(1);
        }
    }
}
