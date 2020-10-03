using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Media;

namespace Excersise_ItemsControl.Models
{
    public interface IPeg
    {
        public Brush PegColor { get; set; }
        public string Name { get; set; }
    }
}
