using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class SalaryCalculator
    {
        public class Employee
        {
            public string Name { get; set; }
            public int Hours { get; set; }
            public double PayRate { get; set; }

            public double GrossPay(int Hours, double PayRate)
            {
                double grossPay;
                if (Hours > 40)
                {
                    grossPay = PayRate * 40;
                    PayRate += PayRate * .5;
                    grossPay += (Hours - 40) * PayRate;
                }
                else
                    grossPay = Hours * PayRate;

                return grossPay;
            }

            public void DisplayPay()
            {
                Console.WriteLine("{0} worked {1} hours. Their gross pay " +
                    "is {2:C}.", this.Name, this.Hours,
                    this.GrossPay(Hours, PayRate));
            }
        }   // end class Employee
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            int counter = 1;
            while (counter <= 3)
            {
                Console.Write("What is this employee's name? ");
                string name = Console.ReadLine();

                Console.Write("How many hours did this employee work " +
                    "this week? ");
                int hours = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is {0}'s pay rate? ", name);
                double payRate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                if (counter == 1)
                {
                    employee1.Name = name;
                    employee1.Hours = hours;
                    employee1.PayRate = payRate;
                }
                else if (counter == 2)
                {
                    employee2.Name = name;
                    employee2.Hours = hours;
                    employee2.PayRate = payRate;
                }
                else
                {
                    employee3.Name = name;
                    employee3.Hours = hours;
                    employee3.PayRate = payRate;
                }

                counter++;
            }   // end while

            employee1.DisplayPay();
            employee2.DisplayPay();
            employee3.DisplayPay();
            Console.WriteLine("Press any button to quit...");
            Console.ReadKey();
        }
    }
}
