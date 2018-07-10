// GradeBookTest.cs
// GradeBook constructor used to specify the course name at the
// time each GradeBook object is created.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookTest
{
    class GradeBookTest
    {
        // Main method begins program execution
        static void Main(string[] args)
        {
            // create a GradeBooke object and assign it to myGradeBook
            GradeBook gradeBook1 = new GradeBook(   // invokes constructor
                "CS101 Introduction to C# Programming", "Ben Davis");
            GradeBook gradeBook2 = new GradeBook(   // invokes constructor
                "CS102 Data Structures in C#", "Ben Davis");

            // display initial value of CourseName
            gradeBook1.DisplayMessage();
            Console.WriteLine();
            gradeBook2.DisplayMessage();
            Console.ReadKey();
        }   // end Main
    }   // end class GradeBookTest
}
