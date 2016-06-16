namespace InterestCalc
{
    using System;

    public delegate double Calculate(double sum, double interest, int years);

    public class InterestCalculator
    {
        private double money;
        private double interest;
        private int years;
        private readonly Calculate someFunction;

        public InterestCalculator(double money, double interest, int years, Calculate callingFunction)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.someFunction = callingFunction;
        }

        public double Money
        {
            get
            {
                return this.money;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public double Interest
        {
            get
            {
                return this.interest;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest cannot be negative");
                }

                this.interest = value;
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Years cannot be negative");
                }

                this.years = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0:F4}", someFunction(this.Money, this.Interest, this.Years));
        }
    }
}
