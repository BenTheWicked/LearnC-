﻿// GradeBook.cs
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
        private int total;          // sum of grades
        private int gradeCounter;   // number of grades entered
        private int aCount;         // count of A grades
        private int bCount;         // count of B grades
        private int cCount;         // count of C grades
        private int dCount;         // count of D grades
        private int fCount;         // count of F grades

        // automatic property CourseName
        public string CourseName { get; set; }

        // constructor initializes automatic property CourseName;
        // int instance variables are initialized to 0 by default
        public GradeBook(string name)
        {
            CourseName = name;      // set CourseName to name
        }   // end constructor

        // display a welcome message to the GradeBook user
        public void DisplayMessage()
        {
            // CourseName gets the name of the course
            Console.WriteLine("Welcome to the grade book for \n{0}!",
                CourseName);
        }   // end method DisplayMessage

        public void InputGrades()
        {
            int grade;              // grade entered by user
            string input;           // text entered by the user

            Console.WriteLine("{0}\n{1}",
                "Enter the integer grades in the range of 0-100.",
                "Type <Ctrl> z and press Enter to terminate input: ");

            input = Console.ReadLine(); // read user input

            // loop until user enters the end-of-file indicator (<Ctrl> z)
            while (input != null)
            {
                grade = Convert.ToInt32(input); // read grade off user input
                total += grade;     // add grade to total
                ++gradeCounter;     // increment number of grades

                // call method to increment appropriate counter
                IncrementLetterGradeCounter(grade);

                input = Console.ReadLine(); // read user input
            }   // end while
        }   // end method InputGrades

        // add 1 to appropriate counter for specified grade
        private void IncrementLetterGradeCounter(int grade)
        {
            // determine which grade was entered
            switch (grade / 10)
            {
                case 9:             // grade was in the 90s
                case 10:            // grade was 100
                    ++aCount;       // increment aCount
                    break;          // necessary to exit switch
                case 8:             // grade was between 80 and 89
                    ++bCount;       // increment bCount
                    break;          // exit switch
                case 7:             // grade was between 70 and 79
                    ++cCount;       // increment cCount
                    break;          // exit switch
                case 6:             // grade was between 60 and 69
                    ++dCount;       // increment dCount
                    break;          // exit switch
                default:            // grade was less than 60
                    ++fCount;       // increment fCount
                    break;          // exit switch
            }   // end switch
        }   // end method IncrementLetterGradeCounter

        // display a report based on the grades entered by the user
        public void DisplayGradeReport()
        {
            Console.WriteLine("\nGrade Report: ");

            // if user entered at least one grade...
            if (gradeCounter != 0)
            {
                // calculate average of all grades entered
                double average = (double)total / gradeCounter;

                // output summary of results
                Console.WriteLine("Total of the {0} grades entered is {1}",
                    gradeCounter, total);
                Console.WriteLine("Class average is {0:F}", average);
                Console.WriteLine("{0}A: {1}\nB: {2}\nC: {3}\nD: {4}\nF: {5}",
                    "Number of students who received each grade:\n",
                    aCount,         // display number of A grades
                    bCount,         // display number of B grades
                    cCount,         // display number of C grades
                    dCount,         // display number of D grades
                    fCount);        // display number of F grades
            }   // end if
            else    // no grades were entered, so output appropriate message
                Console.WriteLine("No grades were entered");
        }   // end method DisplayGradeReport
    }   // end class GradeBook
}
