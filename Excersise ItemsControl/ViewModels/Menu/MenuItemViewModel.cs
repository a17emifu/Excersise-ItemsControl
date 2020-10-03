using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Excersise_ItemsControl.ViewModels.Menu
{
    class MenuItemViewModel
    {
        public string Name { get; set; }
        public string Header { get; set; }
        public ICommand Command { get; set; }
    }
}
