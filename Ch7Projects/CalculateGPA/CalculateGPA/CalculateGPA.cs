using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGPA
{
    class CalculateGPA
    {
        static void Main(string[] args)
        {
            int input;
            int totalGrade = 0;
            int test;

            Console.WriteLine("Please enter a student's four test scores.\n");
            for (test = 1; test <= 4; test++)
            {
                Console.Write("Please input student's grade for test #{0} ", test);
                input = Convert.ToInt32(Console.ReadLine());
                totalGrade += input;
            }
            int gPA = totalGrade / (test - 1);
            switch (gPA/10)
            {
                case 9:
                case 10:
                    Console.WriteLine("This student's GPA is 4.");
                    break;
                case 8:
                    Console.WriteLine("This student's GPA is 3.");
                    break;
                case 7:
                    Console.WriteLine("This student's GPA is 2.");
                    break;
                case 6:
                    Console.WriteLine("This student's GPA is 1.");
                    break;
                default:
                    Console.WriteLine("This student's GPA is 0.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
