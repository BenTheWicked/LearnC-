// WhileCounter.cs
// Counter-controlled repetition with the while repetition statement
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileCounter
{
    class WhileCounter
    {
        static void Main(string[] args)
        {
            int counter = 1;    // declare and initialize control variable

            while (counter <= 10)   // loop-continuation condition
            {
                Console.Write("{0} ", counter);
                ++counter;      // increment control variable
            }   // end while

            Console.WriteLine();    // output a new line
            Console.ReadKey();
        }   // end Main
    }   // end class WhileCounter
}
