using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.CaliburnMicroDemo.Models
{
    
    public class Customer : Base
    {
        private string _firstName;

        public int Id { get; set; }

        public string FirstName
        {
            get => _firstName;
            set => Set(ref _firstName, value);
        }

        public string LastName { get; set; }
        public string Photo { get; set; }
        public bool IsDeleted { get; set; }

        public bool IsSelected { get; set; }
    }
}
