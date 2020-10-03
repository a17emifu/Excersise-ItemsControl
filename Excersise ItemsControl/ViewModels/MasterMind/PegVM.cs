using Excersise_ItemsControl.DataTypes;
using Excersise_ItemsControl.Models;
using Excersise_ItemsControl.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media;

namespace Excersise_ItemsControl.ViewModels.MasterMind
{
    class PegVM : BaseViewModel, IPeg
    {
        public Brush PegColor { get; set; }
        public PegPosition GuessResult { get; set; } = PegPosition.Default;
        public string Name { get; set; }
    }
}
