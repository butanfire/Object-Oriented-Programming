namespace ComputerCatalog.Models
{
    public class Components
    {
        private string name;
        private decimal price;
        private string details;

        public Components(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Components(string name, decimal price, string details) : this(name, price)
        {
            this.details = details;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new System.ArgumentException("Invalid name", "name");
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("Invalid price", "price");
                }

                this.price = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.details = value;
                }
                else
                {
                    throw new System.ArgumentException("Invalid details", "details");
                }
            }
        }
    }
}
