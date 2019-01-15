using Sulmar.WPF.Advanced.IServices;
using Sulmar.WPF.Advanced.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.ViewModels
{

    public class DepartmentsViewModel : ItemsViewModel<Department>
    {
        public DepartmentsViewModel(IDepartmentsService departmentsService) 
            : base(departmentsService)
        {
        }

        public IEnumerable<Department> Departments => Items;

    }
}
