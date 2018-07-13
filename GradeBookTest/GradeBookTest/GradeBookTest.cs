// GradeBookTest.cs
// Create GradeBook object, input grades, and display grade report.
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

            myGradeBook.DisplayMessage();       // display welcome message
            myGradeBook.InputGrades();          // read grades from user
            myGradeBook.DisplayGradeReport();   // display report based on grades
            Console.ReadKey();
        }   // end Main
    }   // end class GradeBookTest
}
