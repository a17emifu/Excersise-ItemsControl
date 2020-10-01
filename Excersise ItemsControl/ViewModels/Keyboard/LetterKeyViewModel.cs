using Excersise_ItemsControl.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Windows.Input;

namespace Excersise_ItemsControl.ViewModels
{
    class LetterKeyViewModel : BaseViewModel
    {
        public char Content { get; set; }
        public ICommand LetterKeyCommand { get; set; }
        public object CommandParameter => Content;

        public double Opacity { get; set; } = 1;
        public string Foreground { get; set; } = "White";
        public string FontWeight { get; set; } = "Normal";
        public bool IsEnabled { get; set; } = true;

        public readonly int QwertyOrder;

        public LetterKeyViewModel(int qwertyOrder, char content, ICommand keyCommand)
        {
            QwertyOrder = qwertyOrder;
            Content = content;
            LetterKeyCommand = keyCommand;
        }

    }
}
