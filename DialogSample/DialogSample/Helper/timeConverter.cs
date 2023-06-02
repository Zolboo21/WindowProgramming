using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DialogSample.Helper
{
    class timeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String time = (String)value;
            if (!string.IsNullOrEmpty(time) && time.Length == 6)
            {
                string hour = time.Substring(0, 2);
                string minute = time.Substring(2, 2);
                string second = time.Substring(4, 2);

                // Convert hour string to 12-hour format and determine AM/PM
                string amPm = "AM";
                int hourValue = int.Parse(hour);
                if (hourValue >= 12)
                {
                    amPm = "PM";
                    if (hourValue > 12)
                        hourValue -= 12;
                }

                hour = hourValue.ToString("00");

                return $"{hour}:{minute}:{second} {amPm}";
            }

            return string.Empty;


        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}