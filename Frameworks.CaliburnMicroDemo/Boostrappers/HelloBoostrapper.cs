using Caliburn.Micro;
using Frameworks.CaliburnMicroDemo.IServices;
using Frameworks.CaliburnMicroDemo.Services;
using Frameworks.CaliburnMicroDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Frameworks.CaliburnMicroDemo.Boostrappers
{
    public class HelloBoostrapper : BootstrapperBase
    {
        private readonly SimpleContainer container = new SimpleContainer();

        public HelloBoostrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            container.Singleton<IWindowManager, WindowManager>();
            container.Singleton<ICustomersService, FakeCustomersService>();
            container.Singleton<ShellViewModel>();
            

        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }

    
}
