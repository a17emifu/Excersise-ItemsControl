using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Excersise_ItemsControl.ViewModels.Base
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
