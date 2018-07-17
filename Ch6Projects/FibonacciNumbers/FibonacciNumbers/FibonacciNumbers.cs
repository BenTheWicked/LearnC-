using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int num1 = 0;               // will always take value of num2
            int num2 = 1;               // will always take value of i
            int input;                  // sequence end

            Console.WriteLine("Let's look at the Fibonacci Sequence.");
            Console.Write("You don't need to know the sequence, but I do need " +
                "to know roughly where to stop. " +
                "\nGive me a whole number: ");
            input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 0; i <= input; i+= num1 + num2)
            {
                Console.Write("{0} ", i);
                num1 = num2;
                num2 = i;
            }
            Console.WriteLine();
            Console.WriteLine("\nPress any key to quit...");
            Console.ReadKey();
        }
    }
}
