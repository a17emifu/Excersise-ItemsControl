using Excersise_ItemsControl.Models;
using Excersise_ItemsControl.ViewModels.Base;
using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace Excersise_ItemsControl.ViewModels.DragDrop
{
    class DDListboxUCVM : BaseViewModel, IDropTarget
    {
        public ObservableCollection<IRecipe> Recipes { get; set; }

        public DDListboxUCVM(ObservableCollection<IRecipe> recipes)
        {
            Recipes = recipes;
        }

        public void DragOver(IDropInfo dropInfo)
        {
            IRecipe sourceItem = dropInfo.Data as IRecipe;
            IRecipe targetItem = dropInfo.TargetItem as IRecipe;

            if (sourceItem != null && targetItem != null)
            {
                dropInfo.DropTargetAdorner = DropTargetAdorners.Highlight;
                dropInfo.Effects = DragDropEffects.Copy;
            }
        }

        public void Drop(IDropInfo dropInfo)
        {
            IRecipe sourceItem = dropInfo.Data as IRecipe;
            IRecipe targetItem = dropInfo.Data as IRecipe;
            //targetItem.Children.Add(sourceItem);
        }
    }
}
