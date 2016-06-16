namespace Problem2_BankOfKurtovoKonare.CustomerAccounts
{
    using System;
    using BankSystem;
    using Interfaces;

    public class MortgageAccount : Accounts, IDeposit
    {
        public MortgageAccount(double balance, double interestRate, CustomerTypes customerType) : base(balance, interestRate, customerType) { }

        public override double CalculateInterest(int months)
        {
            if (months <= 0)
            {
                return 0;
            }

            double temp = this.Balance * (1 + this.InterestRate * months) / 2;
            Console.WriteLine("{0} calculate interest - for {1} months, for customer {2} :", this.GetType().Name, months, this.CustomerType);
            switch (this.CustomerType)
            {
                case CustomerTypes.Companies:
                    if (months > 12)
                    {
                        return temp + (temp * 2);
                    }

                    return temp;
                case CustomerTypes.Individuals:
                    if (months > 6)
                    {
                        return temp * 2;
                    }

                    return 0;
                default:
                    throw new NotSupportedException("Customer type does not exist");
            }
        }        
    }
}
