using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.Models
{
    public class Customer : Base
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public bool IsDeleted { get; set; }

        public bool IsSelected { get; set; }

    }
}
