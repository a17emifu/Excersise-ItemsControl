using Excersise_ItemsControl.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using static Excersise_ItemsControl.ViewModels.Base.RelayParametrizedCommand;

namespace Excersise_ItemsControl.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        public string Letter { get; set; }
        public LetterKeyboardViewModel KeyBoardViewModel { get; set; }

        public MainPageViewModel()
        {
            KeyBoardViewModel = new LetterKeyboardViewModel(new RelayParameterizedCommand(p => LetterClick((char)p)));
        }
        private void LetterClick(char letter)
        {
            KeyBoardViewModel.MarkLetterUsed(letter);
            ShowLetter(letter);
        }

        private void ShowLetter(char letter)
        {
            Letter = letter.ToString();
            //return Letter;
        }
    }
}
