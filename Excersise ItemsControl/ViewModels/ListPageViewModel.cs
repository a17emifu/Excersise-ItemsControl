using Excersise_ItemsControl.Models;
using Excersise_ItemsControl.ViewModels.Base;
using Excersise_ItemsControl.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using static Excersise_ItemsControl.ViewModels.Base.RelayParametrizedCommand;

namespace Excersise_ItemsControl.ViewModels
{
    class ListPageViewModel : BaseViewModel
    {
        public ObservableCollection<IRecipe> Recipes { get; set; }
        public ObservableCollection<IMaterial> RecipesMaterials { get; set; }

        public RecipeListUCViewModel RecipeListUCViewModel { get; set; }
        

        public ListPageViewModel()
        {
            Recipes = new ObservableCollection<IRecipe>();
            MakeRecipes();
            RecipeListUCViewModel = new RecipeListUCViewModel(new RelayParameterizedCommand(p => ListClick((IRecipe)p)), Recipes);
            //RecipeListUCViewModel = new RecipeListUCViewModel(Recipes);
            RecipesMaterials = new ObservableCollection<IMaterial>();
        }
        private void ListClick(IRecipe recipe)
        {
            RecipesMaterials = recipe.Materials;
            //CreateMaterialsList();
        }

        private void CreateMaterialsList()
        {
            foreach (var m in RecipesMaterials) 
            {
                
            };
        }

        private void MakeRecipes()
        {
            ObservableCollection<IMaterial> materialsPasta = new ObservableCollection<IMaterial>
            {
                new Material{ID = 0, Name = "パスタ"},
                new Material{ID = 1, Name = "トマト"}
            };
            ObservableCollection<IMaterial> materialRisotto = new ObservableCollection<IMaterial>
            {
                new Material{ID = 2, Name = "お米"},
                new Material{ID = 3, Name = "ベーコン"}
            };
            Recipe recipe = new Recipe { ID = 1, Name = "パスタ", Materials = materialsPasta };
            Recipe recipe1 = new Recipe { ID = 2, Name = "リゾット", Materials = materialRisotto };

            Recipes.Add(recipe);
            Recipes.Add(recipe1);
        }
    }
}
