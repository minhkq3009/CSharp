using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ForeignCustomers : Customers
    {
        public string Nationality { get; set; }

        public ForeignCustomers(string customerID, string fullName, DateTime invoiceDate, string nationality, double quantity, double unitPrice)
            : base(customerID, fullName, invoiceDate, quantity, unitPrice)
        {
            Nationality = nationality;
        }
    }
}
