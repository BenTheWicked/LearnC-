using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTest
{
    class Date
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        // constructor
        public Date(int mon, int da, int yr)
        {
            Month = mon;
            Day = da;
            Year = yr;
        }   // end constructor

        // DisplayDate method shows month, day, and year with slashes
        public void DisplayDate(int Month, int Day, int Year)
        {
            Console.WriteLine("{0}/{1}/{2}", Month, Day, Year);
        }
    }
}
