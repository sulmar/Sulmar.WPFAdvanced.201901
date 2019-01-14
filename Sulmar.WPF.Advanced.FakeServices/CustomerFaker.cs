using Bogus;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sulmar.WPF.Advanced.FakeServices
{


    // Add to project <CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
    public class CustomerFaker : Faker<Customer>
    {
        public CustomerFaker()
        {
            StrictMode(true);
            RuleFor(p => p.Id, f => f.IndexFaker);
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.Photo, f => f.Person.Avatar);
            RuleFor(p => p.IsDeleted, f => f.Random.Bool(0.8f));
            Ignore(p => p.IsSelected);
            FinishWith((f, c) => Debug.WriteLine($"Customer created {c.FirstName} {c.LastName}"));

        }
    }
}
