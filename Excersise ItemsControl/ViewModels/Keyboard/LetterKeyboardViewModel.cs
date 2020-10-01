using Excersise_ItemsControl.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Excersise_ItemsControl.ViewModels
{
    class LetterKeyboardViewModel: BaseViewModel
    {
        private static readonly char[] _lettersQWERTY = "QWERTYUIOPÅASDFGHJKLÖÄZXCVBNM".ToCharArray();
        private readonly ICommand _keyCommand;

        public ObservableCollection<LetterKeyViewModel> Keys { get; set; }

        public LetterKeyboardViewModel(ICommand keyCommand)
        {
            _keyCommand = keyCommand;

            Keys = new ObservableCollection<LetterKeyViewModel>();

            int qwertyIndex = 0;
            foreach (var c in _lettersQWERTY)
            {
                Keys.Add(new LetterKeyViewModel(qwertyIndex, c, _keyCommand));
                qwertyIndex++;
            }
        }

        public void MarkLetterUsed(char letter)
        {
            var key = Keys.SingleOrDefault(o => o.Content == letter);

            key.Opacity = 0.3;
            //key.Foreground = isCorrect ? "Green" : "Red";
            key.FontWeight = "Bold";
            key.IsEnabled = false;
        }
    }
}
