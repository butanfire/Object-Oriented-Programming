using System.Text;

namespace LaptopShop.Models
{
    public class Laptop
    {
        private string model;
        private decimal price;
        private string manufacturer;
        private string ram;
        private string graphicsCard;

        public Laptop(string model, decimal price)
        { //Contructor 1
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer) : this(model, price) //calling Contructor 1
        { //Constructor 2
            this.Manufacturer = manufacturer;
        }

        public Laptop(string model, decimal price, string manufacturer, string RAM, string graphics) : this(model, price, manufacturer)
        {  //Constructor 3
            this.GaphicsCard = graphics;
            this.ram = RAM;
        }

        public Laptop(string model, decimal price, string manufacturer, string RAM, string graphics, Battery LaptopPower) : this(model, price, manufacturer, RAM, graphics)
        { //Constructor 4
            this.LaptopBattery = LaptopPower;
        }

        public Battery LaptopBattery { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Laptop " + this.model);
            if (this.LaptopBattery != null)
            {
                if (this.LaptopBattery.BatteryLife > 0)
                {
                    result.AppendLine("Battery life " + this.LaptopBattery.BatteryLife + "hours");
                }
                if (this.LaptopBattery.BatteryName != null)
                {
                    result.AppendLine("Battery Name " + this.LaptopBattery.BatteryName);
                }
            }
            if (!string.IsNullOrEmpty(this.manufacturer))
            {
                result.AppendLine("Manufacturer " + this.manufacturer);
            }
            if (!string.IsNullOrEmpty(this.graphicsCard))
            {
                result.AppendLine("Graphics card " + this.graphicsCard);
            }
            if (!string.IsNullOrEmpty(ram))
            {
                result.AppendLine("RAM " + this.ram);
            }

            result.AppendLine("Price " + this.price + "lv.");
            return result.ToString();
        }

        public string Model
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Invalid model", value);
                }

                this.model = value;
            }

            get
            {
                return model;
            }
        }

        public decimal Price
        {
            set
            {
                if (value < 0.0m)
                {
                    throw new System.ArgumentException("Invalid price", "price");
                }

                this.price = value;
            }

            get
            {
                return price;
            }
        }

        public string Manufacturer
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Invalid manufacturer", value);
                }

                this.manufacturer = value;
            }

            get
            {
                return manufacturer;
            }
        }

        public string RAM
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Invalid RAM", value);
                }

                this.ram = value;
            }
            get
            {
                return this.ram;
            }
        }

        public string GaphicsCard
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Invalid graphics", value);
                }

                this.graphicsCard = value;
            }
            get
            {
                return this.graphicsCard;
            }

        }
    }
}
