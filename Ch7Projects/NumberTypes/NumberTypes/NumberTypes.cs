using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTypes
{
    class NumberTypes
    {
        static void Main(string[] args)
        {
            string response;
            int number, factor, sumOfFactors = 0;
            
            Console.Write("Let's try to figure out number types.\n" +
                "To start, give me a number: (q to quit) ");
            response = Console.ReadLine();
            while (!response.Equals("q"))
            {
                number = Convert.ToInt32(response);
                Console.WriteLine("These are the factors of your number:");
                for (factor = 1; factor < number; factor++)
                {
                    if (number % factor == 0)
                    {
                        Console.WriteLine(factor);
                        sumOfFactors += factor;
                    }   // end if factor
                }   // end for

                if (sumOfFactors == 1)
                    Console.WriteLine("Your number {0} " +
                        "is a prime number", number);
                else if (sumOfFactors > number)
                    Console.WriteLine("Your number {0} " +
                        "is an abundant number", number);
                else if (sumOfFactors < number)
                    Console.WriteLine("Your number {0} " +
                        "is a deficient number", number);
                else
                    Console.WriteLine("Your number {0} " +
                        "is a perfect number", number);

                sumOfFactors = 0;
                Console.Write("\nWould you like to try another " +
                    "number? (q to quit) ");
                response = Console.ReadLine();
            }   // end while
        }   // end Main
    }
}
