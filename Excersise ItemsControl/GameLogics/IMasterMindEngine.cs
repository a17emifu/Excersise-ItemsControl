using Excersise_ItemsControl.ViewModels.MasterMind;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Excersise_ItemsControl.GameLogics
{
    interface IMasterMindEngine
    {
        public ObservableCollection<PegVM> PegsResult { get; set; }
        public ObservableCollection<PegVM> TryPegs { get; set; }
        public void MakeAnswer();
        public void CompareAnswer();
    }
}
