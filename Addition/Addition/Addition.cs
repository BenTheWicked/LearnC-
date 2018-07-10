// Addition.cs
// Displaying the sum of two numbers input from the keyboard.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    class Addition
    {
        // Main method begins execution of C# application
        static void Main(string[] args)
        {
            int number1;    // declare first number to add
            int number2;    // declare second number to add
            int sum;        // declare sum of number1 and number2

            Console.Write("Enter first integer: ");     // prompt user
            // read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: ");    //prompt user
            // read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());
            /*
            sum = number1 + number2;    // add numbers

            Console.WriteLine("Sum is {0}", sum);       // display sum
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            */

            if (number1 == number2)
                Console.WriteLine("{0} == {1}", number1, number2);
            if (number1 != number2)
                Console.WriteLine("{0} != {1}", number1, number2);
            if (number1 < number2)
                Console.WriteLine("{0} < {1}", number1, number2);
            if (number1 > number2)
                Console.WriteLine("{0} > {1}", number1, number2);
            if (number1 <= number2)
                Console.WriteLine("{0} <= {1}", number1, number2);
            if (number1 >= number2)
                Console.WriteLine("{0} >= {1}", number1, number2);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
