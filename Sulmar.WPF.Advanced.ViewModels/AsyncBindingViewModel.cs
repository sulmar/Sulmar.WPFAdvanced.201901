using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sulmar.WPF.Advanced.ViewModels
{
    public class AsyncBindingViewModel
    {
        public string Message
        {
            get
            {
                Thread.Sleep(TimeSpan.FromSeconds(5));

                return "Hello World!";
            }
        }

        public string Slow
        {
            get
            {
                Thread.Sleep(10000);
                return "All done";
            }
        }

        public string Medium
        {
            get
            {
                Thread.Sleep(7000);
                return "Nearly there";
            }
        }

        public string Fast
        {
            get
            {
                Thread.Sleep(4000);
                return "Getting ready";
            }
        }
    }
    
}
