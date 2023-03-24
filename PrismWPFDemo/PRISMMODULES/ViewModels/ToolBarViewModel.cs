using PRISMMODULES.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRISMMODULES.ViewModels
{
    class ToolBarViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private ToolbarModule _TM;
        public ToolbarModule TM
        {
            get
            {
                return _TM;
            }
            set
            {
                _TM = value;
                RaisePropertyChanged("_TM");
            }
        }
    }
}
