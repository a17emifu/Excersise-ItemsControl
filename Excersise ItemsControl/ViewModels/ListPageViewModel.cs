﻿using Excersise_ItemsControl.Models;
using Excersise_ItemsControl.ViewModels.Base;
using Excersise_ItemsControl.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Excersise_ItemsControl.ViewModels
{
    class ListPageViewModel : BaseViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; set; }

        public RecipeListUC RecipeListUC { get; set; }

        public ListPageViewModel()
        {
            Recipes = new ObservableCollection<Recipe>();
            MakeRecipes();
            RecipeListUC = new RecipeListUC();
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
