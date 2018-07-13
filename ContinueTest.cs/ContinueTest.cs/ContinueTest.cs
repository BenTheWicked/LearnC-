// ContinueTest.cs
// continue statement terminating an iteration of a for statement.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueTest.cs
{
    class ContinueTest
    {
        static void Main(string[] args)
        {
            for (int count = 1; count <= 10; count++)   // loop 10 times
            {
                if (count == 5)         // if count is 5,
                    continue;           // skip remaining code in the loop

                Console.Write("{0} ", count);
            }   // end for

            Console.WriteLine("\nUsed continue to skip displaying 5");
            Console.ReadKey();
        }
    }
}
