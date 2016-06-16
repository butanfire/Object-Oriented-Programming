using System;
using Problem03.CompanyHierarchy.Interfaces;

namespace Problem03.CompanyHierarchy.Valuables
{
    public class Sale : ISale
    {
        private DateTime date;
        private double price;
        private string productname;

        public Sale(string product, double price, DateTime date)
        {
            this.Date = date;
            this.Price = price;
            this.ProductName = product;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Date cannot be null");
                }

                this.date = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }

                this.price = value;
            }
        }

        public string ProductName
        {
            get
            {
                return this.productname;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Product name cannot be null or empty");
                }

                this.productname = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}\n", this.ProductName, this.Price, this.Date);
        }
    }
}
