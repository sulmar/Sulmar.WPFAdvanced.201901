using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using Sulmar.WPF.Advanced.Common;
using Sulmar.WPF.Advanced.FakeServices;
using Sulmar.WPF.Advanced.IServices;
using Sulmar.WPF.Advanced.WPF;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.RegistrationByConvention;
using Unity.ServiceLocation;

namespace Sulmar.WPF.Advanced.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            UseUnity();

            // UseAutoFac();
        }

        // Install-Package AutoFac
        private void UseAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<FakeCustomersService>().As<ICustomersService>();
            builder.RegisterType<ShellViewModel>();
            builder.RegisterType<CustomersViewModel>();
            builder.RegisterType<CustomerFaker>();
            builder.RegisterType<FrameNavigationService>().As<INavigationService>().SingleInstance();

            IContainer container = builder.Build();


            // Install-Package Autofac.Extras.CommonServiceLocator
            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(container));
        }

       // Install-Package Unity
        private void UseUnity()
        {
            IUnityContainer container = new UnityContainer();            
            container.RegisterType<ICustomersService, FakeCustomersService>();
            container.RegisterSingleton<INavigationService, FrameNavigationService>();

            container.RegisterType<ShellViewModel>();
            container.RegisterType<CustomersViewModel>();
            // container.RegisterSingleton<>

            // Automatyczna rejestracja 
            //container.RegisterTypes(
            //    AllClasses.FromLoadedAssemblies(),
            //    WithMappings.FromMatchingInterface,
            //    WithName.Default);

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));

        }

        // ręcznie
        // public CustomersViewModel CustomersViewModel => new CustomersViewModel(new FakeCustomersService(new CustomerFaker()));

        // Unity
        //  public CustomersViewModel CustomersViewModel => container.Resolve<CustomersViewModel>();

        public CustomersViewModel CustomersViewModel => ServiceLocator.Current.GetInstance<CustomersViewModel>();
        public ShellViewModel ShellViewModel => ServiceLocator.Current.GetInstance<ShellViewModel>();




    }
}
