using System;
using System.Collections.Generic;
using System.Text;

namespace Sulmar.WPF.Advanced.Models
{
    public class OptionsGroup : Base
    {
        public string Name { get; set; }
        public IEnumerable<Option> Options { get; set; }
    }
}
