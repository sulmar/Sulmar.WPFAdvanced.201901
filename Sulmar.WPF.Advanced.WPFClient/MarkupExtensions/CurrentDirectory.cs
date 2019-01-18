using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Sulmar.WPF.Advanced.WPFClient.MarkupExtensions
{
    public class CurrentDirectory : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Environment.CurrentDirectory;
        }
    }
}
