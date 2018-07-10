// AccountTest.cs
// Create and manipulate Account objects.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    public class AccountTest
    {
        // Main method begins execution of C# application
        static void Main(string[] args)
        {
            Account account1 = new Account(50.00M); // create Account object
            Account account2 = new Account(-7.53M); // create Account object

            // display initial balance of each object using a property
            Console.WriteLine("account1 balance: {0:C}",
                account1.Balance);  // display Balance property
            Console.WriteLine("account2 balance: {0:C}\n",
                account2.Balance);

            decimal depositAmount;  // deposit amount read from user

            // prompt and obtain user input
            Console.Write("Enter deposit amount for account1: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account1 balance\n",
                depositAmount);
            account1.Credit(depositAmount); // add to account1 balance

            // display balances
            Console.WriteLine("account1 balance: {0:C}",
                account1.Balance);
            Console.WriteLine("account2 balance: {0:C}\n",
                account2.Balance);

            // prompt and obtain user input
            Console.Write("Enter deposit amount for account2: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account2 balance\n",
                depositAmount);
            account2.Credit(depositAmount);

            // display balances
            Console.WriteLine("account1 balance: {0:C}", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}", account2.Balance);
        }   // end Main
    }   // end class AccountTest
}
