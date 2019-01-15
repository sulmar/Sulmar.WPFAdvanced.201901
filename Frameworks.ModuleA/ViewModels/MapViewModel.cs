using Frameworks.ModuleA.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.ModuleA.ViewModels
{
    public class MapViewModel
    {
        private readonly IMapService mapService;

        public MapViewModel(IMapService mapService)
        {
            this.mapService = mapService;
        }
    }
}
