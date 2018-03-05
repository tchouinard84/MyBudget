using System;
using System.Collections.Generic;
using System.Linq;

namespace MyBudget
{
    public sealed class Month
    {
        public static readonly Month Jan = new Month(MonthEnum.January, "Jan");
        public static readonly Month Feb = new Month(MonthEnum.February, "Feb");
        public static readonly Month Mar = new Month(MonthEnum.March, "Mar");
        public static readonly Month Apr = new Month(MonthEnum.April, "Apr");
        public static readonly Month May = new Month(MonthEnum.May, "May");
        public static readonly Month Jun = new Month(MonthEnum.June, "Jun");
        public static readonly Month Jul = new Month(MonthEnum.July, "Jul");
        public static readonly Month Aug = new Month(MonthEnum.August, "Aug");
        public static readonly Month Sep = new Month(MonthEnum.September, "Sep");
        public static readonly Month Oct = new Month(MonthEnum.October, "Oct");
        public static readonly Month Nov = new Month(MonthEnum.November, "Nov");
        public static readonly Month Dec = new Month(MonthEnum.December, "Dec");

        public string Name { get; }
        private MonthEnum _month;
        private string _mmm;

        private Month(MonthEnum month, string mmm)
        {
            _month = month;
            _mmm = mmm;
            Name = _month.ToString();
        }

        public static IEnumerable<Month> Values()
        {
            return new[] { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
        }

        public static Month FromMMM(string mmm)
        {
            return Values().FirstOrDefault(m => string.Equals(m._mmm, mmm, StringComparison.CurrentCultureIgnoreCase));
        }

        public override string ToString()
        {
            return Name;
        }

        private enum MonthEnum
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
    }
}
