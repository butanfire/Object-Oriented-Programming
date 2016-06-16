using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerCatalog.Models
{
    public class Computer : IComparable
    {
        private string ComputerName;
        private decimal ComputerPrice;
        public List<Components> Components;

        public Computer(string name)
        {
            this.ComputerName = name;
        }

        public Computer(string name, List<Components> Comp) : this(name)
        {
            this.Components = Comp;
        }

        public override string ToString() //overriding the function for displaying and calculating the result
        {
            decimal tempPrice = 0.0M;
            StringBuilder output = new StringBuilder();

            output.AppendLine("ComputerName : " + this.Name); //display the Computer name
            if (this.Components != null)
            {
                foreach (Components Comp in this.Components)
                {
                    output.AppendLine("Component Name :" + Comp.Name); //display the Component name
                    output.AppendLine("Component Price :" + Comp.Price + " BGN");//display the Component price
                    if (!string.IsNullOrEmpty(Comp.Details)) //if there are details, show them
                    {
                        output.AppendLine("Component Details : " + Comp.Details);
                    }
                    tempPrice += Comp.Price; //sum the price for each component for this computer
                }
            }
            this.ComputerPrice = tempPrice; //assign the price for the respective computer
            output.AppendLine("Total Price :" + this.ComputerPrice + " BGN"); //output the price
            return output.ToString();
        }
     
        public decimal Price
        {
            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentException("Invalid price", "price");
                }

                this.ComputerPrice = value;
            }

            get
            {
                return ComputerPrice;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name", "name");
                }

                this.ComputerName = value;
            }

            get
            {
                return ComputerName;
            }
        }

        public int CompareTo(object obj) //implementing the Icomparables for sorting them
        {
            var PC = (Computer)obj;
            return this.Price.CompareTo(PC.Price);
        }
    }
}
