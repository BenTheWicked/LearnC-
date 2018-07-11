// GradeBook.cs
// GradeBook class that solves class-average problem using
// sentinel-controlled repetition.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookTest
{
    public class GradeBook
    {
        // auto-implemented property CourseName
        public string CourseName { get; set; }

        // constructor initializes CourseName property
        public GradeBook(string name)
        {
            CourseName = name;  // set CourseName to name
        }   // end constructor

        // display a welcome message to the GradeBook user
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book for \n{0}!",
                CourseName);
        }   // end method DisplayMessage

        // determine class average of an arbitary number of grades
        public void DetermineClassAverage()
        {
            int total;  // sum of the grades
            int gradeCounter;   // number of the grades entered
            int grade;  // grade value
            double average;    // number with decimal point for average

            // initialization phase
            total = 0;  // initialize the total
            gradeCounter = 0;   // initialize the loop counter

            // processing phase
            // prompt for an read a grade from the user
            Console.WriteLine("Enter grade or -1 to quit: ");
            grade = Convert.ToInt32(Console.ReadLine());

            // loop until sentinel value is read from the user
            while (gradeCounter != -1)
            {
                total = total + grade;  // add the grade to toal
                gradeCounter = gradeCounter + 1;    // increment the counter by 1

                // prompt for and read the next grade from the user
                Console.WriteLine("Enter grade or -1 to quit: ");
                grade = Convert.ToInt32(Console.ReadLine());
            }   // end while

            // termination phase
            // if the user entered at least one grade...
            if (gradeCounter != 0)
            {
                // calculate the average of all the grades entered
                average = (double)total / gradeCounter;

                // display total and average (with two digits of precision)
                Console.WriteLine("\nTotal of the {0} grades entered is {1}",
                    gradeCounter, total);
                Console.WriteLine("Class average is {0:F}", average);
            }   // end if
            else    // no grades were entered, so output error message
                Console.WriteLine("No grades were entered.");
        }   // end method DetermineClassAverage
    }   // end class GradeBook
}
