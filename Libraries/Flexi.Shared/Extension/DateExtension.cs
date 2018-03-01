using System;

namespace Flexi.Shared.Extension
{
    public static class DateExtension
    {
        public static bool Between(this DateTime dt, DateTime startDate, DateTime endDate)
        {
            return dt.Ticks >= startDate.Ticks && dt.Ticks <= endDate.Ticks;
        }

        public static DateTime? DateIsNull(this DateTime value)
        {
            if (value.Year > 1900)
            {
                return value;
            }
            return null;
        }

        public static bool IsWeekend(this DayOfWeek d)
        {
            return !d.IsWeekday();
        }

        public static bool IsWeekday(this DayOfWeek d)
        {
            switch (d)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday: return false;
                default: return true;
            }
        }

        public static DateTime AddWorkdays(this DateTime d, int days)
        {
            // start from a weekday
            while (d.DayOfWeek.IsWeekday()) d = d.AddDays(1.0);
            for (int i = 0; i < days; ++i)
            {
                d = d.AddDays(1.0);
                while (d.DayOfWeek.IsWeekday()) d = d.AddDays(1.0);
            }
            return d;
        }

        public static string FirstDayOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1).ToString("MM/dd/yyyy");
        }

        public static string LastDayOfMonth(this DateTime date)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1).AddDays(-1).ToString("MM/dd/yyyy");
        }
    }
}
