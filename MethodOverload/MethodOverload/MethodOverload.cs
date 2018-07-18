// MethodOverload.cs
// Overloaded method declarations.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class MethodOverload
    {
        // test overloaded square methods
        static void Main(string[] args)
        {
            Console.WriteLine("Square of integer 7 is {0}", Square(7));
            Console.WriteLine("Square of double 7.5 is {0}", Square(7.5));
            Console.ReadKey();
        }   // end Main

        // square method with int argument
        public static int Square(int intValue)
        {
            Console.WriteLine("Called square with int argument: {0}",
                intValue);
            return intValue * intValue;
        }   // end method Square with in argument

        // square method with double argument
        public static double Square(double doubleValue)
        {
            Console.WriteLine("Called square with double argument: {0}",
                doubleValue);
            return doubleValue * doubleValue;
        }   // end method Square with double argument
    }   // end class MethodOverload
}
