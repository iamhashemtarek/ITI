using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    struct HiringDate
    {
        int day;
        int month;
        int year;

        public int Day
        {
            get { return day; }
            set
            {
                if (value < 0 || value > 31)
                    throw new ArgumentOutOfRangeException();
                else
                    day = value;
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value < 0 || value > 12)
                    throw new ArgumentOutOfRangeException();
                else
                    month = value;
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0 || value > 2024)
                    throw new ArgumentOutOfRangeException();
                else
                    year = value;
            }
        }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{day}-{month}-{year}";
        }
    }
}
