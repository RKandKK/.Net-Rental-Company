using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Drawing;
using System.Windows;
using System.Windows.Media;

namespace AplikacjaDoZarzadzaniaWypozyczalnia
{
    class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string color = (string)value;
            return (SolidColorBrush) new BrushConverter().ConvertFromString(color);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((SolidColorBrush) value).ToString();
        }
    }
}
