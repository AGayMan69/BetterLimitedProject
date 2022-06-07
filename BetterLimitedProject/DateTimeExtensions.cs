using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterLimitedProject
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

        public static DateTime GetTodayUpperBound(this DateTime dt)
        {
            return dt.AddDays(1).AddTicks(-1);
        }

        public static DateTime GetThisWeekLowerBound(this DateTime dt)
        {
            return dt.StartOfWeek(DayOfWeek.Monday);
        }

        public static DateTime GetThisWeekUpperBound(this DateTime dt)
        {
            return dt.StartOfWeek(DayOfWeek.Monday).AddDays(7).AddTicks(-1);
        }

        public static DateTime GetThisMonthLowerBound(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1);
        }

        public static DateTime GetThisMonthUpperBound(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1).AddMonths(1).AddTicks(-1);
        }

        public static DateTime GetThisYearLowerBound(this DateTime dt)
        {
            return new DateTime(dt.Year, 1, 1);
        }
        public static DateTime GetThisYearUpperBound(this DateTime dt)
        {
            return new DateTime(dt.Year, 1, 1).AddYears(1).AddTicks(-1);
        }

    }
}
