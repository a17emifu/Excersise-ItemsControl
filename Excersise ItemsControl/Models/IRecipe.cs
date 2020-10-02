using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Excersise_ItemsControl.Models
{
    public interface IRecipe
    {
        int ID { get; set; }
        string Name { get; set; }
        ObservableCollection<IMaterial> Materials { get; set; }

        public bool CanAcceptChildren { get; set; }
        public ObservableCollection<IRecipe> Children { get; set; }
    }
}
