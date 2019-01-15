using Frameworks.CaliburnMicroDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.CaliburnMicroDemo.IServices
{
    public interface ICustomersService
    {
        IEnumerable<Customer> Get();
    }
}
