using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using ModuleA.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA
{
  public class AModule : IModule
  {
    private readonly IRegionViewRegistry _regionViewRegistry = null;

    public AModule(IRegionViewRegistry regionViewRegistry)
    {
      _regionViewRegistry = regionViewRegistry;
    }
    public void Initialize()
    {
      _regionViewRegistry.RegisterViewWithRegion("RibbonRegion", typeof(Aview));
    }
  }
}
