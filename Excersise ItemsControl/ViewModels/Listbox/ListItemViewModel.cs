using Excersise_ItemsControl.Models;
using Excersise_ItemsControl.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excersise_ItemsControl.ViewModels.Listbox
{
    class ListItemViewModel : BaseViewModel
    {
        public IRecipe Recipe { get; set; }
        public ListItemViewModel(IRecipe recipe)
        {
            Recipe = recipe;
        }
    }
}
