using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Excersise_ItemsControl.Models
{
    public class Recipe : IRecipe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ObservableCollection<IMaterial> Materials { get ; set; }
        public bool CanAcceptChildren { get ; set; }
        public ObservableCollection<IRecipe> Children { get; set; }
    }
}
