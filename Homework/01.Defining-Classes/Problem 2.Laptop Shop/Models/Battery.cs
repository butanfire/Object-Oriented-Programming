namespace LaptopShop.Models
{
    public class Battery
    {
        private double batteryLife;
        private string batteryModel;

        public Battery(double batteryLife, string battery)
        {
            this.BatteryLife = batteryLife;
            this.BatteryName = battery;
        }
        
        public string BatteryName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Invalid battery name", value);
                }

                this.batteryModel = value;
            }

            get
            {
                return this.batteryModel;
            }

        }

        public double BatteryLife
        {
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("Invalid battery life", "batteryLife");
                }

                this.batteryLife = value;
            }

            get
            {
                return this.batteryLife;
            }
        }
    }
}
