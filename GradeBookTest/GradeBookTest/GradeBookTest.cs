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
                "CS101 Introduction to C# Programming");
            GradeBook gradeBook2 = new GradeBook(   // invokes constructor
                "CS102 Data Structures in C#");

            // display initial value of CourseName
            Console.WriteLine("gradeBook1 course name is: '{0}'",
                gradeBook1.CourseName);
            Console.WriteLine("gradeBook2 course name is: '{0}'",
                gradeBook2.CourseName);
            Console.ReadKey();
        }   // end Main
    }   // end class GradeBookTest
}
