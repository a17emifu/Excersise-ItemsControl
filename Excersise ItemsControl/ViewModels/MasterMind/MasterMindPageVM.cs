using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media;

namespace Excersise_ItemsControl.ViewModels.MasterMind
{
    class MasterMindPageVM
    {
        public PegUCVM PegUCVM { get; set; }
        public ObservableCollection<PegVM> Pegs {get; set;}

        public MasterMindPageVM()
        {
            Pegs = new ObservableCollection<PegVM>();
            MakePegs();
            PegUCVM = new PegUCVM(Pegs);
        }

        private void MakePegs()
        {
            PegVM pegYellow = new PegVM() { PegColor = Brushes.Yellow };
            PegVM pegGreen = new PegVM() { PegColor = Brushes.Green };
            PegVM pegRed = new PegVM() { PegColor = Brushes.Red };

            Pegs.Add(pegYellow);
            Pegs.Add(pegRed);
            Pegs.Add(pegGreen);
        }
    }
}
