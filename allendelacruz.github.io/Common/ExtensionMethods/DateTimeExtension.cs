using System;

namespace allendelacruz.github.io.Common.ExtensionMethods
{
    public static class DateTimeExtension
    {
        // https://stackoverflow.com/questions/4127363/date-difference-in-years-using-c-sharp
        public static int GetDifferenceInYears(this DateTime startDate, DateTime endDate)
        {
            var zeroTime = new DateTime(1, 1, 1);

            TimeSpan span = endDate - startDate;
            // Because we start at year 1 for the Gregorian
            // calendar, we must subtract a year here.
            int years = (zeroTime + span).Year - 1;

            return years;
        }
    }
}