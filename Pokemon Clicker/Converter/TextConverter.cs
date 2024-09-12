using System.Globalization;
using System;
using Avalonia.Data.Converters;
using Pokemon_Clicker.Enemy;

namespace Pokemon_Clicker.ViewModels
{
    internal class TextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Здесь предполагается, что value - это текст, который вы хотите преобразовать.
            if (value is CEnemyTemplate entity)
            {
                // Пример преобразования текста - добавление каких-то данных или форматирование.
                return entity.GetName();
            }

            return Avalonia.Data.BindingNotification.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // В случае, если обратное преобразование не нужно, можно вернуть UnsetValue
            return Avalonia.Data.BindingNotification.UnsetValue;
        }
    }
}
