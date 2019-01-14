using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPF.Advanced.Common
{
    public interface INavigationService
    {
        void Navigate(string viewname, object parameter = null);
        void GoForward();
        void GoBack();

        object Parameter { get; }
    }
}
