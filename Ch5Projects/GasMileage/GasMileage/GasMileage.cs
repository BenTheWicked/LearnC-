using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasMileage
{
    class GasMileage
    {
        static void Main(string[] args)
        {
            int miles;
            int gallons;
            int rides = 0;
            double averageMPG;
            double totalAverageMPG = 0;
            double result;

            Console.WriteLine("How many miles did you drive? (-1 to quit) ");
            miles = Convert.ToInt32(Console.ReadLine());
            while (miles != -1)
            {
                Console.WriteLine("How many gallons were used? ");
                gallons = Convert.ToInt32(Console.ReadLine());

                rides++;

                averageMPG = (double)miles / gallons;
                Console.WriteLine("The miles per gallon for this trip " +
                    "were {0:F}.", averageMPG);
                totalAverageMPG += averageMPG;

                Console.WriteLine("How many miles did you drive on " +
                    "the next trip? (-1 to quit) ");
                miles = Convert.ToInt32(Console.ReadLine());
            }   // end while

            if (rides != 0)
            {
                result = totalAverageMPG / rides;
                Console.WriteLine("Your car's average miles per gallon " +
                    "for {0} trips is {1}", rides, result);
            }
            else
                Console.WriteLine("No trips were recorded.");
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}
