using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    class TemperatureConversion
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("What Fahrenheit temperature would you " +
                "like to convert? (q to quit) ");
            input = Console.ReadLine();

            while (!input.Equals("q"))
            {
                double temp = Convert.ToDouble(input);
                if (temp == 32)
                {
                    Console.WriteLine("32 degrees Fahrenheit is " +
                        "0 degrees Celcius.\n");
                }
                else
                {
                    double celcius = 5.0 / 9.0 * (temp - 32);
                    Console.WriteLine("{0:F} degrees Fahrenheit is {1:F} " +
                        "degrees Celcius.\n", input, celcius);
                }
                
                Console.Write("What Fahrenheit temperature would you " +
                    "like to convert? (q to quit) ");
                input = Console.ReadLine();
            }

            Console.WriteLine("Come back again for a quick conversion!");
            Console.ReadKey();
        }
    }
}
