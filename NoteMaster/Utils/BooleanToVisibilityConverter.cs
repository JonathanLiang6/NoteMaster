using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace NoteMaster.Utils
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                bool boolValue = value is bool boolVal ? boolVal : false; // Ĭ��ֵΪ false
                bool inverse = parameter?.ToString() == "Inverse";

                if (inverse)
                {
                    boolValue = !boolValue;
                }

                return boolValue ? Visibility.Visible : Visibility.Collapsed;
            }
            catch (Exception ex)
            {
                // ��¼�쳣�Ա����
                Console.WriteLine($"BooleanToVisibilityConverter ת��ʧ��: {ex.Message}");
                return Visibility.Collapsed; // Ĭ������
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}