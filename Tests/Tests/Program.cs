using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(7.5));
            Console.WriteLine(Math.Floor(7.5));
            Console.WriteLine(Math.Abs(0.0));
            Console.WriteLine(Math.Ceiling(0.0));
            Console.WriteLine(Math.Abs(-6.4));
            Console.WriteLine(Math.Ceiling(-6.4));
            Console.WriteLine(Math.Ceiling(-Math.Abs(-8 + Math.Floor(-5.5))));
            Console.ReadKey();
        }
    }
}
