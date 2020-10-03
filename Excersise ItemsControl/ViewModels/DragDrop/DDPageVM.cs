using Excersise_ItemsControl.Models;
using Excersise_ItemsControl.ViewModels.Base;
using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Excersise_ItemsControl.ViewModels.DragDrop
{
    class DDPageVM : BaseViewModel
    {
        public ObservableCollection<IRecipe> Recipes { get; set; }
        public ObservableCollection<IRecipe> Recipes2 { get; set; }
        public DDListboxUCVM DDListboxUCVM { get; set; }
        public DDListboxUCVM DDListboxUCVM2 { get; set; }

        public ICommand ViewRecipeCommand { get; set; }

        public DDPageVM()
        {
            Recipes = new ObservableCollection<IRecipe>();
            Recipes2 = new ObservableCollection<IRecipe>();


            MakeRecipes();
            MakeRecipes2();
            DDListboxUCVM = new DDListboxUCVM(Recipes);
            DDListboxUCVM2 = new DDListboxUCVM(Recipes2);

            ViewRecipeCommand = new RelayCommand(ViewRecipe);


        }

        private void ViewRecipe()
        {
            ObservableCollection<IRecipe> recipes = Recipes;
        }

        private void MakeRecipes2()
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
            Recipe recipe = new Recipe { ID = 1, Name = "ラーメン", Materials = materialsPasta, CanAcceptChildren=true };
            Recipe recipe1 = new Recipe { ID = 2, Name = "うどん", Materials = materialRisotto, CanAcceptChildren = true };
            Recipe recipe2 = new Recipe { ID = 3, Name = "そば", Materials = materialOnigiri, CanAcceptChildren = true };

            Recipes2.Add(recipe);
            Recipes2.Add(recipe1);
            Recipes2.Add(recipe2);
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
