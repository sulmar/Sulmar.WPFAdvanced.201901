using Frameworks.PrismDemo.IServices;
using Frameworks.PrismDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.PrismDemo.Services
{
    public class FakeCustomersService : ICustomersService
    {
        public IEnumerable<Customer> Get()
        {
            throw new NotImplementedException();
        }
    }
}
