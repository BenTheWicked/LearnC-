using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresAndCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}\t{1}\t{2}", "number", "square", "cube");
            Console.WriteLine("{0}\t{1}\t{2}", 0, 0 * 0, 0 * 0 * 0);
            Console.WriteLine("{0}\t{1}\t{2}", 1, 1 * 1, 1 * 1 * 1);
            Console.WriteLine("{0}\t{1}\t{2}", 2, 2 * 2, 2 * 2 * 2);
            Console.WriteLine("{0}\t{1}\t{2}", 3, 3 * 3, 3 * 3 * 3);
            Console.WriteLine("{0}\t{1}\t{2}", 4, 4 * 4, 4 * 4 * 4);
            Console.WriteLine("{0}\t{1}\t{2}", 5, 5 * 5, 5 * 5 * 5);
            Console.WriteLine("{0}\t{1}\t{2}", 6, 6 * 6, 6 * 6 * 6);
            Console.WriteLine("{0}\t{1}\t{2}", 7, 7 * 7, 7 * 7 * 7);
            Console.WriteLine("{0}\t{1}\t{2}", 8, 8 * 8, 8 * 8 * 8);
            Console.WriteLine("{0}\t{1}\t{2}", 9, 9 * 9, 9 * 9 * 9);
            Console.WriteLine("{0}\t{1}\t{2}", 10, 10 * 10, 10 * 10 * 10);
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
