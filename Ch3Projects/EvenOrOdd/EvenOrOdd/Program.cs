using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string result;

            Console.WriteLine("I bet I can determine if you number " +
                "is even or odd.");
            Console.Write("Enter a whole number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                result = "EVEN";
            }
            else
            {
                result = "ODD";
            }

            Console.WriteLine("That was a hard one, but I think " +
                "your number {0} is {1}!", num, result);
            Console.WriteLine("That was fun, but I'm ready to rest.");
            Console.WriteLine("Press any button to quit...");
            Console.ReadKey();
        }
    }
}
