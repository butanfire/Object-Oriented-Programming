namespace Problem2_BankOfKurtovoKonare.BankSystem
{
    using System;

    public abstract class Accounts
    {
        private CustomerTypes customerType;
        private double interestRate;
        private double balance;

        protected Accounts(double balance, double interestRate, CustomerTypes customer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.CustomerType = customer;
        }

        public CustomerTypes CustomerType
        {
            get
            {
                return this.customerType;
            }

            set
            {
                switch (value)
                {
                    case CustomerTypes.Companies:
                        this.customerType = CustomerTypes.Companies;
                        break;
                    case CustomerTypes.Individuals:
                        this.customerType = CustomerTypes.Individuals;
                        break;
                    default:
                        throw new NotSupportedException("Customer type not supported.");
                }
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative");
                }

                this.balance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest Rate cannot be negative");
                }

                this.interestRate = value;
            }
        }

        public void Deposit(double depositAmount)
        {
            this.Balance += depositAmount;
            Console.WriteLine("Deposited {0} successfully", depositAmount);
        }

        public abstract double CalculateInterest(int months);

        public override string ToString()
        {
            return string.Format("Balance : {0}\nInterest Rate : {1}\nCustomer Type : {2}", this.Balance, this.InterestRate, this.CustomerType);
        }
    }
}
