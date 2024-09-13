using System.Globalization;
using System;
using Avalonia.Data.Converters;
using Pokemon_Clicker.Enemy;
using Pokemon_Clicker.Visibility;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace Pokemon_Clicker.ViewModels
{
    internal class IconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CIcon icon)
            {
                return new Bitmap(icon.GetPath());
            }

            return Avalonia.Data.BindingNotification.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Avalonia.Data.BindingNotification.UnsetValue;
        }
    }
}
