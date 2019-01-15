using Frameworks.PrismDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.PrismDemo.IServices
{
    public interface ICustomersService
    {
        IEnumerable<Customer> Get();
    }
}
