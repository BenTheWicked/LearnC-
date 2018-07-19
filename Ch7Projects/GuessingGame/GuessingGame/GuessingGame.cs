using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class GuessingGame
    {
        static void Main(string[] args)
        {
            Random rNG = new Random();
            int number = rNG.Next(1, 101);
            int guess = 0;
            int count = 1;
            string response;

            Console.Write("Guess a whole number between 1 and 100. Press q to quit.\n" +
                "What number am I thinking of? ");
            response = Console.ReadLine();

            while (!response.Equals('q') && number != guess)
            {
                guess = Convert.ToInt32(response);

                if (guess == number)
                {
                    Console.Write("Congrats! You win!\n" +
                        "Number of Guesses = {0}\n" +
                        "Press any key to quit.", count);
                    Console.ReadKey();
                    break;
                }   // win the game
                else if (guess < number)
                    Console.WriteLine("That guess was too low.");
                else
                    Console.WriteLine("That guess was too high.");

                count++;
                Console.Write("Don't give up now! Guess again! (but if you do want to give up now, press q) ");
                response = Console.ReadLine();
            }
        }
    }
}
