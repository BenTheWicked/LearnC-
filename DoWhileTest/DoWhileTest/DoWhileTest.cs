// DoWhileTest.cs
// do...while repetition statement.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileTest
{
    class DoWhileTest
    {
        static void Main(string[] args)
        {
            int counter = 1;            // initialize counter

            do
            {
                Console.Write("{0} ", counter);
                ++counter;
            } while (counter <= 10);    // end do...while

            Console.WriteLine();        // outputs a new line
            Console.ReadKey();
        }   // end Main
    }   // end class DoWhileTest
}
