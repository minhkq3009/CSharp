using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Customers
    {
        public string CustomerID { get; set; }
        public string FullName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }

        public Customers(string customerID, string fullName, DateTime invoiceDate, double quantity, double unitPrice)
        {
            CustomerID = customerID;
            FullName = fullName;
            InvoiceDate = invoiceDate;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public virtual double CalculateTotal()
        {
            return Quantity * UnitPrice;
        }
    }
}
