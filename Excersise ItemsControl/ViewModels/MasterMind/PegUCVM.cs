using Excersise_ItemsControl.ViewModels.Base;
using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;

namespace Excersise_ItemsControl.ViewModels.MasterMind
{
    class PegUCVM : BaseViewModel, IDropTarget
    {
        public ObservableCollection<PegVM> Pegs { get; set; }

        public PegUCVM (ObservableCollection<PegVM> pegs)
        {
            Pegs = pegs;
        }
        public void DragOver(IDropInfo dropInfo)
        {
            PegVM sourceItem = dropInfo.Data as PegVM;
            PegVM targetItem = dropInfo.Data as PegVM;

            if (sourceItem != null && targetItem != null && targetItem.CanAcceptChildren)
            {
                dropInfo.DropTargetAdorner = DropTargetAdorners.Highlight;
                dropInfo.Effects = DragDropEffects.Copy;
            }
        }

        public void Drop(IDropInfo dropInfo)
        {
            PegVM sourceItem = dropInfo.Data as PegVM;
            PegVM targetItem = dropInfo.Data as PegVM;
            targetItem.Children.Add(sourceItem);
        }
    }
}
