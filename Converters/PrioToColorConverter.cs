using AJ8AND.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace AJ8AND.Converters
{
    public class PrioToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if ((Priority)value == Priority.High)
                return "Red";
            else if ((Priority)value == Priority.Normal)
                return "Yellow";
            return "Green";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
