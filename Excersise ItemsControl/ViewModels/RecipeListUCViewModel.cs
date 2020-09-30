using Excersise_ItemsControl.Models;
using Excersise_ItemsControl.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Excersise_ItemsControl.ViewModels
{
    class RecipeListUCViewModel : BaseViewModel
    {
        private readonly ICommand _listCommand;
        public ObservableCollection<RecipeViewModel> RecipesWithCommand { get; set; }

        public RecipeListUCViewModel(ICommand listcommand, ObservableCollection<Recipe> recipes)
        {
            _listCommand = listcommand;
            RecipesWithCommand = new ObservableCollection<RecipeViewModel>();

            foreach(var r in recipes)
            {
                RecipesWithCommand.Add(new RecipeViewModel(r, _listCommand));
            }
        }
    }
}
