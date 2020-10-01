﻿using Excersise_ItemsControl.Models;
using Excersise_ItemsControl.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Excersise_ItemsControl.ViewModels.Listbox
{
    class ListboxUCViewModel : BaseViewModel
    {
        public ObservableCollection<IRecipe> Recipes { get; set; }
        public IRecipe Recipe { get; set; }
        public string Name { get; set; }
        public ICommand ShowCommand { get; set; }
        //public ObservableCollection<ListItemViewModel> RecipesWithVM { get; set; }
        public ListboxUCViewModel(ObservableCollection<IRecipe> recipes)
        {
            Recipe = new Recipe();
            Recipes = recipes;
            ShowCommand = new RelayCommand(ShowRecipeName);
            /*RecipesWithVM = new ObservableCollection<ListItemViewModel>();
            foreach (var r in recipes)
            {
                RecipesWithVM.Add(new ListItemViewModel(r));
            }*/
        }

        private void ShowRecipeName()
        {
            Name = Recipe.Name;
        }
    }
}
