using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class MathOperations
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The SUM of {0} and {1} is {2}",
                num1, num2, num1 + num2);
            Console.WriteLine("The PRODUCT of {0} and {1} is {2}",
                num1, num2, num1 * num2);
            Console.WriteLine("The DIFFERENCE of {0} and {1} is {2}",
                num1, num2, num1 - num2);
            Console.WriteLine("The QUOTIENT of {0} divided by {1} is {2}",
                num1, num2, num1 / num2);
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
