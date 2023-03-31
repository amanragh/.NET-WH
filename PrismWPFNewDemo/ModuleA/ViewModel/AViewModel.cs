using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ModuleA.ViewModel
{
  public class AViewModel : INotifyPropertyChanged
  {
    public AViewModel()
    {
      ModuleAContent = "This is Ribbon Region module(ModuleA loaded here), Basically we can use it to display menus";
    }
    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    private string _moduleAContent;
    public string ModuleAContent
    {
      get => _moduleAContent;
      set
      {
        _moduleAContent = value;
        OnPropertyChanged(nameof(ModuleAContent));
      }
    }
  }
}
