using Excersise_ItemsControl.DataTypes;
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


        public MasterMindEngine( ObservableCollection<PegVM> pegsOnBoard, ObservableCollection<PegVM> pegsResult)
        {
            answerPegs = new ObservableCollection<PegVM>();
            PegsResult = pegsResult;
            TryPegs = pegsOnBoard;
            //MakeAnswer();
            MakePegsResult();
            //ConvertColor();
        }

        private void MakePegsResult()
        {
            PegsResult = new ObservableCollection<PegVM>();
            for (int i = 0; i < 3; i++) 
            {
                PegsResult.Add(new PegVM());
            }
        }

        public ObservableCollection<PegVM> CompareAnswer()
        {
            int i = 0;
            MakecolorDictionary();
            foreach(var peg in TryPegs)
            {
                if (peg.PegColor.Equals(answerPegs[i].PegColor)) //GREEN
                {
                    PegsResult[i].GuessResult = PegPosition.CorrectColorAndPosiiton;
                }
                else if (answersColor.Contains(peg.Name))//YELLO AND RED
                {
                    PegsResult[i].GuessResult = PegPosition.CorrectColorWrongPosition;
                }
                else
                {
                    PegsResult[i].GuessResult = PegPosition.TotalyWrong;

                }
                i++;
            }
            return PegsResult;
        }
        private ObservableCollection<string> answersColor;
        private void MakecolorDictionary()
        {
            answersColor = new ObservableCollection<string>();
            foreach(var answerPeg in answerPegs)
            {
                answersColor.Add(answerPeg.Name);
            }
        }

        public ObservableCollection<PegVM> MakeAnswer()
        {
            PegVM peg1 = new PegVM() { PegColor = Brushes.Red, Name="Red" };
            PegVM peg2 = new PegVM() { PegColor = Brushes.Green, Name = "Green"};
            PegVM peg3 = new PegVM() { PegColor = Brushes.Red, Name="Red" };

            answerPegs.Add(peg1);
            answerPegs.Add(peg2);
            answerPegs.Add(peg3);


            return answerPegs;
        }
    }
}
