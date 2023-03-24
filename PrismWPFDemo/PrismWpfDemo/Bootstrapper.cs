using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWpfDemo
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            return this.Container.Resolve<PrismAppShell>();
        }
        protected override void InitializeModules()
        {
            base.InitializeModules();
            App.Current.MainWindow = (PrismAppShell)this.Shell;
            App.Current.MainWindow.Show();
        }
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(PRISMMODULES.Model.ToolbarModule));
        }
    }
}
