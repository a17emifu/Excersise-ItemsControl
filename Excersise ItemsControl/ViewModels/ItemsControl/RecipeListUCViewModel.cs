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
        //public ICommand ShowCommand { get; set; }
        public ObservableCollection<RecipeViewModel> RecipesWithCommand { get; set; }
        public ObservableCollection<RecipeViewModel> RecipesWithVM { get; set; }

        public ObservableCollection<IRecipe> Recipes;
        public RecipeViewModel SelectedRecipe { get; set; }
        public ICommand MaterialViewCommand { get; set; }
        // public object ListParameter => Recipe;

        // public ObservableCollection<IMaterial> RecipesMaterials { get; set; }

       public RecipeListUCViewModel(ObservableCollection<IRecipe> recipes)
         {
            ////ShowCommand = showCommand;
            //SelectedRecipe = new RecipeViewModel();
            Recipes = recipes;
            RecipesWithVM = new ObservableCollection<RecipeViewModel>();
            foreach(var r in recipes)
            {
                RecipesWithVM.Add(new RecipeViewModel(r));
            }
         }

        public RecipeListUCViewModel(ICommand listcommand, ObservableCollection<IRecipe> recipes)
        {
            /*Recipe = new Recipe();
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
