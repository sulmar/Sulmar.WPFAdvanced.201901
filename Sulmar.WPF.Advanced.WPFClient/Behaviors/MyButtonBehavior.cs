using Microsoft.Xaml.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sulmar.WPF.Advanced.WPFClient.Behaviors
{
    public class MyButtonBehavior : Behavior<Button>
    {
        protected override void OnAttached()
        {

            Button button = this.AssociatedObject;

            button.MouseEnter += Button_MouseEnter;
            base.OnAttached();
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            
        }
    }
}
