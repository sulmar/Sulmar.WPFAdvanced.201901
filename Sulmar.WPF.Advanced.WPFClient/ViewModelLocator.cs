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
            // UseUnity();

            UseAutoFac();
        }

        // Install-Package AutoFac
        private void UseAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<FakeCustomersService>().As<ICustomersService>();
            builder.RegisterType<FakeDepartmentsService>().As<IDepartmentsService>().SingleInstance();
            builder.RegisterType<FakeOptionsGroupsService>().As<IOptionsGroupsService>().SingleInstance();
            builder.RegisterType<ShellViewModel>();
            builder.RegisterType<CustomersViewModel>().SingleInstance();
            builder.RegisterType<DepartmentsViewModel>().SingleInstance();
            builder.RegisterType<OptionsGroupsViewModel>().SingleInstance();
            builder.RegisterType<AsyncBindingViewModel>();
            builder.RegisterType<CustomerViewModel>();
            builder.RegisterType<CustomerFaker>();
            builder.RegisterType<DepartmentFaker>();
            builder.RegisterType<OptionsGroupFaker>();
            builder.RegisterType<OptionFaker>();
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
            container.RegisterSingleton<IDepartmentsService, FakeDepartmentsService>();
            container.RegisterSingleton<INavigationService, FrameNavigationService>();

            container.RegisterType<ShellViewModel>();
            container.RegisterType<CustomersViewModel>();
            container.RegisterType<DepartmentsViewModel>();

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

        public ShellViewModel ShellViewModel => ServiceLocator.Current.GetInstance<ShellViewModel>();
        public CustomersViewModel CustomersViewModel => ServiceLocator.Current.GetInstance<CustomersViewModel>();        
        public DepartmentsViewModel DepartmentsViewModel => ServiceLocator.Current.GetInstance<DepartmentsViewModel>();
        public CustomerViewModel CustomerViewModel => ServiceLocator.Current.GetInstance<CustomerViewModel>();
        public OptionsGroupsViewModel OptionsGroupsViewModel => ServiceLocator.Current.GetInstance<OptionsGroupsViewModel>();
        public AsyncBindingViewModel AsyncBindingViewModel => ServiceLocator.Current.GetInstance<AsyncBindingViewModel>();
    }
}
