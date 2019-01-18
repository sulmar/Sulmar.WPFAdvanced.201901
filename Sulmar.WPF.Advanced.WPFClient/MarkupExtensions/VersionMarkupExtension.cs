using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Sulmar.WPF.Advanced.WPFClient.MarkupExtensions
{
    [DefaultProperty("Size")]
    public class VersionMarkupExtension : MarkupExtension
    {

        public VersionMarkupExtension()
        {

        }

        public VersionMarkupExtension(int size)
        {
            this.Size = size;
        }
        
        public int Size { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Assembly.GetEntryAssembly().GetName().Version.ToString();
        }
    }
}
