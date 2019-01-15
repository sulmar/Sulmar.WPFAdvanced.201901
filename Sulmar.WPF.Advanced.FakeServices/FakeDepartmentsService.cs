using Sulmar.WPF.Advanced.IServices;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.FakeServices
{
    public class FakeDepartmentsService : IDepartmentsService
    {
        private readonly IEnumerable<Department> departments;

        public FakeDepartmentsService(DepartmentFaker departmentFaker)
        {
            this.departments = departmentFaker.Generate(10);
        }

        public IEnumerable<Department> Get()
        {
            return departments;
        }
    }
}
