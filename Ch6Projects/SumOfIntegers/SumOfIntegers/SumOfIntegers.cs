using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfIntegers
{
    class SumOfIntegers
    {
        static void Main(string[] args)
        {
            string input;           // get an input
            int total = 0;              // add each number to total

            Console.WriteLine("Let's calculate the sum of odd numbers.");
            Console.Write("To start, give me an odd number (q to quit): ");
            input = Console.ReadLine();
            while (!input.Equals("q"))
            {
                int number = Convert.ToInt32(input);
                if (number % 2 == 0)
                {
                    Console.Write("Please enter an odd number: ");
                    input = Console.ReadLine();
                    continue;
                }

                if (number > 0)
                {
                    for (int i = 1; i <= number; i += 2)
                    {
                        total += i;
                        if (i != number)
                            Console.Write("{0} + ", i);
                        else
                            Console.Write("{0} = ", i);
                    }

                    Console.Write("{0}\n", total);
                    total = 0;
                }
                else
                {
                    for (int i = -1; i>= number; i -= 2)
                    {
                        total += i;
                        if (i != number)
                            Console.Write("{0} ", i);
                        else
                            Console.Write("{0} = ", i);
                    }

                    Console.Write("{0}\n", total);
                    total = 0;
                }

                Console.Write("\nWould you like to calculate another " +
                    "number?\nEnter an odd number or press q to quit. ");
                input = Console.ReadLine();
            }
        }
    }
}
