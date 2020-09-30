﻿using Excersise_ItemsControl.Models;
using Excersise_ItemsControl.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Excersise_ItemsControl.ViewModels
{
    class RecipeViewModel : BaseViewModel
    {
        public Recipe Recipe { get; set; }
        public ICommand MaterialViewCommand { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }

        public RecipeViewModel (Recipe recipe, ICommand listCommand)
        {
            Recipe = recipe;
            MaterialViewCommand = listCommand;

            ID = Recipe.ID;
            Name = Recipe.Name;
        }
    }
}
