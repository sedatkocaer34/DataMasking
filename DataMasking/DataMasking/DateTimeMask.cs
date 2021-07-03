using System;
using System.Collections.Generic;
using System.Text;

namespace DataMasking
{
    public static class DateTimeMask
    {
        public static string CreateNewMask(DateTime Date)
        {
            var day = Date.Day.ToString();
            var month = Date.Month.ToString();
            var year = Date.Year.ToString();
            var response = GetMaskDayAndMonth(day,month) + GetMaskYear(year);
            return response;
        }

        public static string GetMaskDayAndMonth(string Day, string Month)
        {
            var maskingSign = '*';
            Day = CheckLenght(Day.ToString());
            Month = CheckLenght(Month.ToString());

            var maskValueDay = string.Concat("".PadLeft(1, maskingSign),Day.Substring(1, 1));
            var maskValueMonth = string.Concat("".PadLeft(1, maskingSign), Month.Substring(1, 1));

            var response = maskValueDay + maskValueMonth;
            return response;
        }

        public static string GetMaskYear(string Year)
        {
            var maskingSign = '*';

            var maskValue = string.Concat(Year.Substring(0, 3), "".PadRight(1, maskingSign));
            return maskValue;
        }

        public static string CheckLenght(string Value)
        {
            if (Value.Length==1)
            {
                Value = "0" + Value;
            }
            return Value;
        }
    }
}
