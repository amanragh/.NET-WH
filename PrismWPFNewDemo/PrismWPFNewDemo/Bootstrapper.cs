using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using System.Windows;
using ModuleA;
using System.Reflection;

namespace PrismWPFNewDemo
{
  class Bootstrapper : UnityBootstrapper
  {
    protected override DependencyObject CreateShell()
    {
      return Container.TryResolve<PrismShell>();
    }

    protected override void InitializeModules()
    {
      base.InitializeModules();
      Application.Current.MainWindow = (PrismShell)Shell;
      Application.Current.MainWindow.Show();
    }
    protected override void ConfigureModuleCatalog()
    {
      base.ConfigureModuleCatalog();
      ModuleCatalog moduleCatalog = (ModuleCatalog)ModuleCatalog;
      moduleCatalog.AddModule(typeof(AModule));

    }
  }
}
