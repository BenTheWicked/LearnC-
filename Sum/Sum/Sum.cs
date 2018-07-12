// Sum.cs
// Summing integers with the for statement
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Sum
    {
        static void Main(string[] args)
        {
            int total = 0;  // initialize total

            // total even integers from 2 through 20
            for (int number = 2; number <= 20; number += 2)
                total += number;

            Console.WriteLine("Sum is {0}", total);
            Console.ReadKey();
        }   // end Main
    }   // end Class Sum
}
