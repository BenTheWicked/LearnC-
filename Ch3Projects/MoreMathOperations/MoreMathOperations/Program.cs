using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.Write("Enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.Write("Enter your third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num2 > num3)
            {
                int temp = num2;
                num2 = num3;
                num3 = temp;
            }
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            Console.WriteLine("The SUM of your numbers is {0}",
                num1 + num2 + num3);
            Console.WriteLine("The AVERAGE of your numbers is {0}",
                (num1 + num2 + num3) / 3);
            Console.WriteLine("The SMALLEST of your numbers is {0}",
                num1);
            Console.WriteLine("The LARGEST of your numbers is {0}",
                num3);
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
