using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int n = 1; n <= i; n++)
                    total *= n;
                Console.WriteLine("{0}! = {1}", i, total);
                total = 1;
            }
            Console.ReadKey();
            /*
             * What difficulty might prevent you from calculating to 20!?
            As the factorial climbs, it grows exponentially. By the time
            the loop would get to 20!, an int data type will not be able
            to hold the value of total.
            */
        }
    }
}
