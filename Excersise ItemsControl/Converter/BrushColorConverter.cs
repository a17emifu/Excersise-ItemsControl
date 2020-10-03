using Excersise_ItemsControl.DataTypes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace Excersise_ItemsControl.Converter
{
    class BrushColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var pegPosition = (PegPosition)value;
            switch (pegPosition)
            {
                case PegPosition.CorrectColorAndPosiiton:
                    return new SolidColorBrush(Colors.Green);
                case PegPosition.CorrectColorWrongPosition:
                    return new SolidColorBrush(Colors.Yellow);
                case PegPosition.TotalyWrong:
                    return new SolidColorBrush(Colors.Red);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
