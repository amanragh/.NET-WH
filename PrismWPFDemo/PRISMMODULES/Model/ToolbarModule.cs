using PRISMMODULES.View;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRISMMODULES.Model
{
    public class ToolbarModule : IModule, INotifyPropertyChanged
    {
        private readonly IRegionViewRegistry regionViewRegistry = null;
        public ToolbarModule(IRegionViewRegistry regionViewRegistry)
        {
            this.regionViewRegistry = regionViewRegistry;
        }
        public void Initialize()
        {
            this.regionViewRegistry.RegisterViewWithRegion("HeaderRegion", typeof(ToolbarWindow));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
