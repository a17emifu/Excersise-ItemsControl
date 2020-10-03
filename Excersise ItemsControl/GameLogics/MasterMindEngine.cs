using Excersise_ItemsControl.ViewModels.Base;
using Excersise_ItemsControl.ViewModels.MasterMind;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media;

namespace Excersise_ItemsControl.GameLogics
{
    class MasterMindEngine : BaseViewModel, IMasterMindEngine
    {
        private ObservableCollection<PegVM> answerPegs { get; set; }
        public ObservableCollection<PegVM> TryPegs { get; set; }
        public ObservableCollection<PegVM> PegsResult { get; set; }


        public MasterMindEngine( ObservableCollection<PegVM> pegsOnBoard)
        {
            answerPegs = new ObservableCollection<PegVM>();
            PegsResult = new ObservableCollection<PegVM>();
            TryPegs = pegsOnBoard;
            MakeAnswer();
            MakePegsResult();
            //ConvertColor();
        }

        private void MakePegsResult()
        {
            PegsResult.Clear();
            for (int i = 0; i < 3; i++) 
            {
                PegsResult.Add(new PegVM());
            }
        }

        public void CompareAnswer()
        {
           
            foreach(var peg in answerPegs)
            {
                if (TryPegs.Contains(peg))
                {
                    // Green or Yellow
                    int index = TryPegs.IndexOf(peg);
                    PegsResult[index] = new PegVM() { PegColor = Brushes.Green, Name = "Green" };
                }
                else //RED
                {
                    int index = TryPegs.IndexOf(peg);
                    PegsResult[index] = new PegVM() { PegColor = Brushes.Red, Name = "Red" };
                }
            }
        }

        public void MakeAnswer()
        {
            PegVM peg1 = new PegVM() { PegColor = Brushes.Red, Name="Red" };
            PegVM peg2 = new PegVM() { PegColor = Brushes.Green, Name = "Green"};
            PegVM peg3 = new PegVM() { PegColor = Brushes.Red, Name="Red" };

            answerPegs.Add(peg1);
            answerPegs.Add(peg2);
            answerPegs.Add(peg3);


            
        }
    }
}
