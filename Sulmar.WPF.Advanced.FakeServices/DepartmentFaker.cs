using Bogus;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.FakeServices
{
    public class DepartmentFaker : Faker<Department>
    {
        public DepartmentFaker(CustomerFaker customerFaker)
        {
            StrictMode(true);
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.Name, f => f.Commerce.Department());
            RuleFor(p => p.Customers, f => customerFaker.Generate(f.Random.Int(3, 10)));
        }
    }
}
