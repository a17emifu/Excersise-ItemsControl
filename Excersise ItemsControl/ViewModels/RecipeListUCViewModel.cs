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
       /* public IRecipe Recipe { get; set; }
        public ICommand MaterialViewCommand { get; set; }
        public object ListParameter;*/

        // public ObservableCollection<IMaterial> RecipesMaterials { get; set; }

        /* public RecipeListUCViewModel(ObservableCollection<IRecipe> recipes)
         {
             RecipesMaterials = new ObservableCollection<IMaterial>();
             RecipesWithCommand = new ObservableCollection<RecipeViewModel>();
             foreach (var r in recipes)
             {
                 RecipesWithCommand.Add(new RecipeViewModel(r));
             }
         }*/
        public RecipeListUCViewModel(ICommand listcommand, ObservableCollection<IRecipe> recipes)
        {
           /* Recipe = new Recipe();
            MaterialViewCommand = listcommand;*/
            _listCommand = listcommand;
            RecipesWithCommand = new ObservableCollection<RecipeViewModel>();

            foreach(var r in recipes)
            {
                RecipesWithCommand.Add(new RecipeViewModel(r, _listCommand));
               // ListParameter = r;
               /* MaterialViewCommand = _listCommand;
                Recipe = r;*/
            }
        }
    }
}
