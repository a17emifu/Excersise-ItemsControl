using Excersise_ItemsControl.ViewModels.Base;
using GongSolutions.Wpf.DragDrop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;

namespace Excersise_ItemsControl.ViewModels.MasterMind
{
    class PegUCVM : BaseViewModel, IDropTarget
    {
        public ObservableCollection<PegVM> Pegs { get; set; }
        private ObservableCollection<PegVM> _pegs { get; set; }
        public ObservableCollection<PegVM> PegsOnBoard { get; set; }


        public PegUCVM (ObservableCollection<PegVM> pegs, ObservableCollection<PegVM> pegsOnBoard)
        {
            Pegs = pegs;
            _pegs = pegs;
            PegsOnBoard = pegsOnBoard;
        }
        /*  void IDropTarget.DragOver(IDropInfo dropInfo)
          {
              PegVM sourceItem = dropInfo.Data as PegVM;
              PegVM targetItem = dropInfo.Data as PegVM;

              if (sourceItem != null && targetItem != null && targetItem.CanAcceptChildren)
              {
                  dropInfo.DropTargetAdorner = DropTargetAdorners.Highlight;
                  dropInfo.Effects = DragDropEffects.Copy;
              }
          }*/
        void IDropTarget.DragOver(IDropInfo dropInfo)
        {
            PegVM sourceItem = dropInfo.Data as PegVM;
            PegVM targetItem = dropInfo.Data as PegVM;

            if (sourceItem != null && targetItem != null && targetItem.CanAcceptChildren)
            {
                dropInfo.DropTargetAdorner = DropTargetAdorners.Highlight;
                dropInfo.Effects = DragDropEffects.Copy;
                //Pegs = _pegs;
            }
            
        }

        void IDropTarget.Drop(IDropInfo dropInfo)
        {
            PegVM sourceItem = dropInfo.Data as PegVM;
            PegVM targetItem = dropInfo.TargetItem as PegVM;
            if (PegsOnBoard.Contains(targetItem))
            {
                int x = PegsOnBoard.IndexOf(targetItem);
                PegsOnBoard[x] = sourceItem;
                //targetItem = sourceItem;
            }
            //PegsOnBoard.Add(sourceItem);
            Pegs = _pegs;

            //(ObservableCollection)dropInfo.DragInfo.target
            //targetItem.Children.Add(sourceItem);
            //((IList)dropInfo.DragInfo.SourceCollection).Remove(pupil);
            //Pegs.Remove(targetItem);
        }
    }
}
