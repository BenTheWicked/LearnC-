﻿// FactorialTest.cs
// Recursive Factorial method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTest
{
    class FactorialTest
    {
        static void Main(string[] args)
        {
            // calculate the factorials of 0 through 10
            for (long counter = 0; counter <= 10; counter++)
                Console.WriteLine("{0}! = {1}",
                    counter, Factorial(counter));
            Console.ReadKey();
        }   // end Main

        // recursive declaration of method Factorial
        public static long Factorial(long number)
        {
            // base case
            if (number <= 1)
                return 1;
            // recursion step
            else
                return number * Factorial(number - 1);
        }   // end method Factorial
    }   // end class FactorialTest
}
