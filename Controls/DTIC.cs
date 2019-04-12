using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace Server_Restart_Final
{
    [ValueConversion(typeof(string), typeof(ICommand))]
    public class DTIC : IValueConverter
    {
        public static DTIC Instance = new DTIC();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var path = (string)value;
            if (path == null)
                return null;

           

            return new RelayCommand(Global.GlobalSigh.TreeViewItemClick);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
