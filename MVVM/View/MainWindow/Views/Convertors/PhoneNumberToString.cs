using System;
using System.Globalization;
using System.Windows.Data;
using BankingAppMVVM.MVVM.Model.Accounts.ProtectedData;

namespace BankingAppMVVM.MVVM.View.Convertors
{
    public class PhoneNumberToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is PhoneNumber data)) return null;

            return data.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}