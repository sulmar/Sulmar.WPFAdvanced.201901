using Frameworks.ModuleA.IServices;
using Frameworks.ModuleA.Services;
using Frameworks.ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.ModuleA
{
    // Install-Package Prism.Core
    public class AModule : IModule
    {
        private readonly IRegionManager regionManager;

        public AModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
           // var regionManager = containerProvider.Resolve<IRegionManager>();

                regionManager.RegisterViewWithRegion("ContentRegion", typeof(MapView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IMapService, GoogleMapService>();
        }
    }
}
