using Sulmar.WPF.Advanced.IServices;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sulmar.WPF.Advanced.FakeServices
{
    public class FakeDepartmentsService : IDepartmentsService
    {
        private readonly IEnumerable<Department> departments;

        public FakeDepartmentsService(DepartmentFaker departmentFaker)
        {
            this.departments = departmentFaker.Generate(100);
        }

        public IEnumerable<Department> Get() => departments;

        public Department Get(int id) => departments.SingleOrDefault(c => c.Id == id);
    }
}
