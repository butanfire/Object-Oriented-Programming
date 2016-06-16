namespace Problem2_BankOfKurtovoKonare.CustomerAccounts
{
    using System;
    using BankSystem;
    using Interfaces;

    public class LoanAccount : Accounts, IDeposit
    {
        public LoanAccount(double balance, double interestRate, CustomerTypes CustomerType) : base(balance, interestRate, CustomerType)
        {
        }

        public override double CalculateInterest(int months)
        {
            Console.WriteLine("{0} calculate interest - for {1} months, for customer {2} :", this.GetType().Name, months, this.CustomerType);
            switch (this.CustomerType)
            {
                case CustomerTypes.Companies:
                    if (months - 2 >= 1)
                    {
                        return this.Balance * (1 + this.InterestRate * months);
                    }

                    return 0;
                case CustomerTypes.Individuals:
                    {
                        if (months - 3 >= 1)
                        {
                            return this.Balance * (1 + this.InterestRate * months);
                        }

                        return 0;
                    }
                default:
                    throw new NotSupportedException("Customer type does not exist for this operation");
            }
        }
    }
}
