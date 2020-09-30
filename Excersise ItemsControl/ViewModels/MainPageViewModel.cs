using Excersise_ItemsControl.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static Excersise_ItemsControl.ViewModels.Base.RelayParametrizedCommand;

namespace Excersise_ItemsControl.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        public string Letter { get; set; }
        public LetterKeyboardViewModel KeyBoardViewModel { get; set; }
        public ObservableCollection<char> WordDisplay { get; set; }
        public int CurrentWordLength { get => Letter?.Length ?? 0; }

        public MainPageViewModel()
        {
            KeyBoardViewModel = new LetterKeyboardViewModel(new RelayParameterizedCommand(p => LetterClick((char)p)));
            WordDisplay = new ObservableCollection<char>();
        }
        private void LetterClick(char letter)
        {
            KeyBoardViewModel.MarkLetterUsed(letter);
            ShowLetter(letter);
            ShowLetters(letter);
        }

        private void ShowLetters(char letter)
        {
            WordDisplay.Add(letter);
        }

        private void ShowLetter(char letter)
        {
            Letter = letter.ToString();
            //return Letter;
        }
    }
}
