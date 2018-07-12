// Interest.cs
// Compound-interest calculations with for.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest
{
    class Interest
    {
        static void Main(string[] args)
        {
            decimal amount;         // amount on deposit at end of each year
            decimal principal = 1000;   // initial amount before interest
            double rate = 0.05;     // interest rate

            // display headers
            Console.WriteLine("Year{0,20}", "Amount on deposit");

            // calculate amount on deposit for each ten years
            for (int year = 1; year <= 10; year++)
            {
                // calculate new amount for specified year
                amount = principal *
                    ((decimal)Math.Pow(1.0 + rate, year));

                // display the year and amount
                Console.WriteLine("{0,4}{1,20:C}", year, amount);
            }   // end for
            Console.ReadKey();
        }   // end Main
    }   // end class Interest
}
