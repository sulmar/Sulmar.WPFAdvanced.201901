﻿using Sulmar.WPF.Advanced.IServices;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.ViewModels
{
    public class CustomersViewModel : ViewModelBase
    {
        public IEnumerable<Customer> Customers { get; set; }

        private readonly ICustomersService customersService;

        public CustomersViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            Load();
        }

        private void Load()
        {
            Customers = customersService.Get();
        }
    }
}