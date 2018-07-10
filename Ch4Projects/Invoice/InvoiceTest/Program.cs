using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("12345", 
                "Flux Capacitor", 999, 100);
            Console.WriteLine("How much would you like to buy? (max of 999)");
            int amount = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Buying {0} of {1}, part " +
                "number {2}, costs {3:C}.", amount, invoice1.PartDescription,
                invoice1.PartNumber,
                invoice1.GetInvoiceAmount(amount, invoice1.ItemPrice));
            Console.WriteLine("Press Enter to quit...");
            Console.ReadKey();
        }
    }
}
