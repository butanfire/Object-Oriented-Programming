namespace Customer.Models
{
    using System;

    public class Payment
    {
        private string pname;
        private double price;

        public Payment(string pname, double price)
        {
            this.Price = price;
            this.ProductName = pname;
        }

        public string ProductName
        {
            get
            {
                return this.pname;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Product cannot be null");
                }

                this.pname = value;
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
                if(value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return $"{this.ProductName}: {this.Price:C0}";
        }
    }
}
