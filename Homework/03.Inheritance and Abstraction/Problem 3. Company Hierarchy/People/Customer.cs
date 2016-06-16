using System;
using Problem03.CompanyHierarchy.Interfaces;

namespace Problem03.CompanyHierarchy.People
{
    public class Customer : Person, ICustomer
    {
        private double netAmount;

        public Customer(string id, string fname, string lname, double net) : base(id, fname, lname)
        {
            this.netPurchaseAmount = net;
        }

        public double netPurchaseAmount
        {
            get
            {
                return this.netAmount;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Net amount cannot be negative");
                }

                this.netAmount = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", this.Firstname, this.Lastname, this.ID, this.netPurchaseAmount);
        }
    }
}
