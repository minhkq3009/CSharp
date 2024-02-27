using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class VietnamCustomers : Customers
    {
        public string CustomerType { get; set; }
        public double ExceedQuantity { get; set; }
        public double NewUnitPrice { get; set; }

        public VietnamCustomers (string customerID, string fullName, DateTime invoiceDate, string customerType, double quantity, double unitPrice, double exceedQuantity, double newUnitPrice)
            : base(customerID, fullName, invoiceDate, quantity, unitPrice)
        {
            CustomerType = customerType;
            ExceedQuantity = exceedQuantity;
            NewUnitPrice = newUnitPrice;
        }

        public override double CalculateTotal()
        {
            if (Quantity <= ExceedQuantity)
            {
                return Quantity * UnitPrice;
            }
            else
            {
                return ExceedQuantity * UnitPrice + (Quantity - ExceedQuantity) * NewUnitPrice;
            }
        }
    }
}
