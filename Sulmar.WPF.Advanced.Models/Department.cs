using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.Models
{
    public class Department : Base
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Customer> Customers { get; set; }
    }
}
