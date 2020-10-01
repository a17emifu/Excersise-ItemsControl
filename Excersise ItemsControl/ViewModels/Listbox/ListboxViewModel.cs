using Excersise_ItemsControl.Models;
using Excersise_ItemsControl.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Excersise_ItemsControl.ViewModels.Listbox
{
    class ListboxViewModel : BaseViewModel
    {
        public ListboxUCViewModel ListboxUCViewModel { get; set; }
        public ObservableCollection<IRecipe> Recipes { get; set; }

        public ListboxViewModel()
        {
            Recipes = new ObservableCollection<IRecipe>();
            MakeRecipes();
            ListboxUCViewModel = new ListboxUCViewModel(Recipes);
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
            ObservableCollection<IMaterial> materialOnigiri = new ObservableCollection<IMaterial>
            {
                new Material{ID = 2, Name = "お米"},
                new Material{ID = 4, Name = "海苔"}
            };
            Recipe recipe = new Recipe { ID = 1, Name = "パスタ", Materials = materialsPasta };
            Recipe recipe1 = new Recipe { ID = 2, Name = "リゾット", Materials = materialRisotto };
            Recipe recipe2 = new Recipe { ID = 3, Name = "おにぎり", Materials = materialOnigiri };

            Recipes.Add(recipe);
            Recipes.Add(recipe1);
            Recipes.Add(recipe2);
        }

    }
}
