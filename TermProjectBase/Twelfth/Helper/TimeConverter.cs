using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Twelfth.Helper
{
    class TimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string time = value as string;

            string hour = time.Substring(0, 2);
            string min = time.Substring(2, 2);
            string sec = time.Substring(4, 2);

            int inthour = System.Convert.ToInt32(hour);
            string formatedTime;

            if (inthour > 12)
            {
                inthour -= 12;

//                formatedTime = inthour.ToString("D2") + ":" + min + ":" + sec + " AM";

                formatedTime = string.Format("{0, 2:D2}:{1, 2}:{2, 2} PM", inthour, min, sec);
            }
            else
            {
                formatedTime = hour + ":" + min + ":" + sec + " AM";
            }

            return formatedTime;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
