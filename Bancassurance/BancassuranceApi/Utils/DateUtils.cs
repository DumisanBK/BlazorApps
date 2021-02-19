using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BancassuranceApi.Utils
{
    public class DateUtils
    {
        public static long FindDifferenceBetweenThenAndNow(long thenAsLong)
        {
            string today = GetFormattedToday();

            long nowAsLong = Convert.ToInt64(today);

            long difference = nowAsLong - thenAsLong;

            return difference;
        }

        public static int FindDifferenceBetweenThenAndNow(string thenAsString)
        {
            string today = GetFormattedToday();

            int thatYear = Convert.ToInt32(thenAsString.Substring(0, 4));
            int thisYear = Convert.ToInt32(today.Substring(0, 4));

            int difference = thisYear - thatYear;

            return difference;
        }

        public static string GetFormattedToday()
        {
            string today = FormatDate(DateTime.Now).Replace("/", string.Empty);

            return today;
        }

        public static string FormatDate(DateTime dateTimeToFormat, string pattern = "yyyy/MM/dd")
        {
            string formattedDate = dateTimeToFormat.ToString(pattern);

            return formattedDate;
        }

        public static bool IsSimilar(DateTime dateTime1, DateTime dateTime2)
        {
            bool similarYear = dateTime1.Year == dateTime2.Year;
            bool similarMonth = dateTime1.Month == dateTime2.Month;
            bool similarDay = dateTime1.Day == dateTime2.Day;

            return similarDay && similarMonth && similarYear;
        }
    }
}
