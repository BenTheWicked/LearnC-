using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysInAMonth
{
    class DaysInAMonth
    {
        public string nextMonth(string month, int year, int days)
        {
            Console.WriteLine("{0}, {1} had {2} days.", month, year, days);
            Console.Write("\nPlease type another month (or \"quit\" " +
                "to quit): ");
            return month = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            DaysInAMonth obj = new DaysInAMonth();
            string month;           // store the month
            int year;               // store year
            int days;               // return days
            bool leapYear;          // find leap year

            Console.Write("Welcome to Days in a Month by Ben Davis.\n" +
                "Please type a month with proper casing (type \"quit\" to quit): ");
            month = Console.ReadLine();

            while (!month.Equals("quit") && !month.Equals("Quit"))
            {
                if (!month.Equals("January") &&
                    !month.Equals("February") &&
                    !month.Equals("March") &&
                    !month.Equals("April") &&
                    !month.Equals("May") &&
                    !month.Equals("June") &&
                    !month.Equals("July") &&
                    !month.Equals("August") &&
                    !month.Equals("September") &&
                    !month.Equals("October") &&
                    !month.Equals("November") &&
                    !month.Equals("December"))
                {
                    Console.Write("I did not understand that. Check your " +
                        "spelling and make sure to capitalize.\n" +
                        "Which month would you like me to look up? ");
                    month = Console.ReadLine();
                    continue;
                }   // end check spelling

                Console.Write("Now, enter a year: ");
                year = Convert.ToInt32(Console.ReadLine());

                if (((year % 4 == 0) && (year % 100 != 0)) || year % 400 == 0)
                    leapYear = true;
                else
                    leapYear = false;

                switch (month)
                {
                    case "January":
                    case "March":
                    case "May":
                    case "July":
                    case "August":
                    case "October":
                    case "December":
                        days = 31;
                        month = obj.nextMonth(month, year, days);
                        break;
                    case "April":
                    case "June":
                    case "September":
                    case "November":
                        days = 30;
                        month = obj.nextMonth(month, year, days);
                        break;
                    default:
                        days = (leapYear ? 29 : 28);
                        month = obj.nextMonth(month, year, days);
                        break;
                }
            }
        }
    }
}
