﻿using System.Globalization;
using System;
using Avalonia.Data.Converters;
using Pokemon_Clicker.Enemy;

namespace Pokemon_Clicker.ViewModels
{
    internal class TextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CEnemyTemplate entity)
            {
                return entity.GetName();
            }

            return Avalonia.Data.BindingNotification.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Avalonia.Data.BindingNotification.UnsetValue;
        }
    }
}
