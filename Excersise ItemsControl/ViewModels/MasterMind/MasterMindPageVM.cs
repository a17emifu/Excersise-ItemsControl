using Excersise_ItemsControl.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using System.Windows.Input;
using System.Windows.Media;

namespace Excersise_ItemsControl.ViewModels.MasterMind
{
    class MasterMindPageVM : BaseViewModel
    {
        public PegUCVM PegUCVM { get; set; }
        //public PegUCVM PegBoardUC { get; set; }
        public ObservableCollection<PegVM> Pegs {get; set;}
        public ObservableCollection<PegVM> PegsOnBoard { get; set; }

        public ICommand CheckPegsCommand { get; set; }
        public ICommand CheckPegsOnBoardCommand { get; set; }

        public MasterMindPageVM()
        {
            Pegs = new ObservableCollection<PegVM>();
            PegsOnBoard = new ObservableCollection<PegVM>();
            
            MakePegs();
            MakePegsOnBoard();
            PegUCVM = new PegUCVM(Pegs, PegsOnBoard);
            //PegBoardUC = new PegUCVM(PegsOnBoard);

            CheckPegsCommand = new RelayCommand(CheckPegs);
            CheckPegsOnBoardCommand = new RelayCommand(CheckPegsOnBoard);
        }

        private void CheckPegsOnBoard()
        {
            ObservableCollection<PegVM> pegs = PegsOnBoard;
        }

        private void CheckPegs()
        {
            ObservableCollection<PegVM> pegs = Pegs;
        }

        private void MakePegsOnBoard()
        {
            PegsOnBoard.Clear();
            for(int i =0; i<3; i++)
            {
                PegsOnBoard.Add(new PegVM());
            }

        }

        private void MakePegs()
        {
            PegVM pegYellow = new PegVM() { PegColor = Brushes.Yellow, CanAcceptChildren = true };
            PegVM pegGreen = new PegVM() { PegColor = Brushes.Green, CanAcceptChildren = true };
            PegVM pegRed = new PegVM() { PegColor = Brushes.Red,  CanAcceptChildren = true };

            Pegs.Add(pegYellow);
            Pegs.Add(pegRed);
            Pegs.Add(pegGreen);
        }
    }
}
