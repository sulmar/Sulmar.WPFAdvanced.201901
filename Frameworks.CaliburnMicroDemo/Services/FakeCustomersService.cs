
using Frameworks.CaliburnMicroDemo.IServices;
using Frameworks.CaliburnMicroDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.CaliburnMicroDemo.Services
{
    public class FakeCustomersService : ICustomersService
    {
        public IEnumerable<Customer> Get()
        {
            throw new NotImplementedException();
        }
    }
}
