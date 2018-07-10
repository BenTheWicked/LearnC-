using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTest
{
    class DateTest
    {
        static void Main(string[] args)
        {
            // create three objects
            Date chelsyBDate = new Date(1, 15, 1988);
            Date benBDate = new Date(9, 15, 1984);
            Date millerBDate = new Date(12, 28, 2012);

            chelsyBDate.DisplayDate(chelsyBDate.Month,
                chelsyBDate.Day, chelsyBDate.Year);
            benBDate.DisplayDate(benBDate.Month, benBDate.Day,
                benBDate.Year);
            millerBDate.DisplayDate(millerBDate.Month,
                millerBDate.Day, millerBDate.Year);
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
