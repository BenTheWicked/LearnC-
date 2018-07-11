// Increment.cs
// Prefix increment and postfix increment operators.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment
{
    class Increment
    {
        static void Main(string[] args)
        {
            int c;

            // demonstrate postfix increment operator
            c = 5;                  // assign 5 to c
            Console.WriteLine(c);   // display 5
            Console.WriteLine(c++); // display 5 again, then increment
            Console.WriteLine(c);   // display 6

            Console.WriteLine();    // skip a line

            // demonstrate prefix increment operator
            c = 5;                  // assign 5 to c
            Console.WriteLine(c);   // display 5
            Console.WriteLine(++c); // increment, then display
            Console.WriteLine(c);   // display 6 again

            Console.ReadKey();
        }   // end Main
    }   // end class Increment
}
