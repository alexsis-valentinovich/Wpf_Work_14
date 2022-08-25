using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Globalization;

namespace Wpf_Work_14
{
    class Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((ProductCategorys)value == ProductCategorys.Food)
            {
                return "Еда";
            }
            else
            {
                if ((ProductCategorys)value == ProductCategorys.Appliances)
                {
                    return "Бытовая техника";
                }
                else
                {
                    return "Одежда";
                }
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
