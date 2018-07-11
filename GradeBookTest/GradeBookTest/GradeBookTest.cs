// GradeBookTest.cs
// Create GradeBook object and invoke its DetermineClassAverage method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookTest
{
    class GradeBookTest
    {
        static void Main(string[] args)
        {
            // create a GradeBooke myGradeBook and
            // pass course name to constructor
            GradeBook myGradeBook = new GradeBook(
                "CS101 Introduction to C# Programming");

            myGradeBook.DisplayMessage();   // display welcome message
            myGradeBook.DetermineClassAverage();    // find average of 10 grades
            Console.ReadLine();
        }   // end Main
    }   // end class GradeBookTest
}
