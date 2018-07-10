using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceTest
{
    class Invoice
    {
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }

        // Invoice constructor
        public Invoice(string firstPartNum, string firstPartDesc,
            int initialQuantity, decimal initialPrice)
        {
            PartNumber = firstPartNum;
            PartDescription = firstPartDesc;
            Quantity = initialQuantity;
            ItemPrice = initialPrice;
        }

        // GetInvoiceAmount method calculates the amounts and returns
        // the amount as a decimal
        public decimal GetInvoiceAmount(int amount, decimal ItemPrice)
        {
            decimal total = amount * ItemPrice;
            Quantity -= amount;
            return total;
        }
    }
}
