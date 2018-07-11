// Analysis.cs
// Analysis of examination results, using nested control statements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    class Analysis
    {
        static void Main(string[] args)
        {
            // initialize variables in declarations
            int passes = 0;         // number of passes
            int failures = 0;       // number of failures
            int studentCounter = 1; // student counter
            int result;             // one exame result from user

            // process 10 students using counter-controlled repetition
            while (studentCounter <= 10)
            {
                // prompt user for input and obtain a value from the user
                Console.Write("Enter result (1 = pass, 2 = fail): ");
                result = Convert.ToInt32(Console.ReadLine());

                // if...else nested in while
                if (result == 1)            // if result 1,
                    passes = passes + 1;        // increment passes
                else                        // else result is not 1, so
                    failures = failures + 1;    // increment failures

                // increment studentCounter so loop eventually terminates
                studentCounter = studentCounter + 1;
            }   // end while

            // termination phase; prepare and display results
            Console.WriteLine("Passed: {0}\nFailed: {1}", passes, failures);

            // determine whether more than 8 students passed
            if (passes > 8)
                Console.WriteLine("Bonus to instructor!");
            Console.ReadKey();
        }   // end main
    }   // end class Analysis
}
