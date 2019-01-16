using Sulmar.WPF.Advanced.IServices;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sulmar.WPF.Advanced.ViewModels
{
    public class CustomersViewModel : ItemsViewModel<Department>
    {
        private Customer _selectedCustomer;

        public CustomersViewModel(IDepartmentsService itemsService)
: base(itemsService)
        {

        }

        public IEnumerable<Department> Departments => Items;

        public IEnumerable<Customer> Customers => Items.SelectMany(d => d.Customers);

        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;

                OnPropertyChanged();
            }
        }

        //private readonly ICustomersService customersService;

        //public CustomersViewModel(ICustomersService customersService)
        //{
        //    this.customersService = customersService;

        //    Load();
        //}

        //private void Load()
        //{
        //    Customers = customersService.Get();
        //}
    }
}
