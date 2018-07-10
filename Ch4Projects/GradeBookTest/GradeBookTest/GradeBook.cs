// GradeBook.cs
// GradeBook class that contains a courseName instance variable,
// and a property to get and set its value.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookTest
{
    public class GradeBook
    {
        // auto-implemented property CourseName implicitly created an
        // instance variable for this GradeBook's course name
        public string CourseName { get; set; }

        // auto-implemented property InstructorName creates an instance
        // variable for the GradeBook's instructor
        public string Instructor { get; set; }

        // constructor initializes auto-implemented property
        // CourseName with string supplied as an argument
        public GradeBook(string name, string teacher)
        {
            CourseName = name;  // set CourseName to name
            Instructor = teacher;
        }   // end constructor

        // display a welcome message to the GradeBook user
        public void DisplayMessage()
        {
            // use auto-implemented property CourseName to get the
            // name of the course that this GradeBook represents
            Console.WriteLine("Welcome to the grade book for \n{0}!",
                CourseName);    // display property CourseName
            Console.WriteLine("This course is presented by:\n{0}.",
                Instructor);
        }   // end method DisplayMessage
    }   // end class GradeBook
}
