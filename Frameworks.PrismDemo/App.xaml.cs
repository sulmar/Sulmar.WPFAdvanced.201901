using CommonServiceLocator;
using Frameworks.PrismDemo.IServices;
using Frameworks.PrismDemo.Services;
using Frameworks.PrismDemo.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Frameworks.PrismDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<ShellView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CustomersView>();

            containerRegistry.Register<ICustomersService, FakeCustomersService>();
        }

        //protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        //{
        //    base.ConfigureModuleCatalog(moduleCatalog);

        //    moduleCatalog.AddModule<AModule>();
        //}

        protected override IModuleCatalog CreateModuleCatalog()
        {
            // na podst. app.config
            // return new ConfigurationModuleCatalog();

            return new DirectoryModuleCatalog { ModulePath = Environment.CurrentDirectory };


            // return base.CreateModuleCatalog();
        }
    }
}
