// ForCounter.cs
// Counter-controlled repetition with the for repetition statement.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCounter
{
    class ForCounter
    {
        static void Main(string[] args)
        {
            // for statement header includes initialization,
            // loop-continuation condition and increment
            for (int counter = 1; counter <= 10; counter++)
                Console.Write("{0} ", counter);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
