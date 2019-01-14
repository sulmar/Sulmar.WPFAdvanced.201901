using Sulmar.WPF.Advanced.IServices;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;

namespace Sulmar.WPF.Advanced.FakeServices
{
    public class FakeCustomersService : ICustomersService
    {
        private readonly IEnumerable<Customer> customers;

        public FakeCustomersService(CustomerFaker customerFaker)
        {
            customers = customerFaker.Generate(100);
        }

        public IEnumerable<Customer> Get() => customers;
    }
}
