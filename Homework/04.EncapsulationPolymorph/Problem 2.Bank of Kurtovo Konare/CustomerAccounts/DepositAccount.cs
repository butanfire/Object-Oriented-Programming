namespace Problem2_BankOfKurtovoKonare.CustomerAccounts
{
    using System;
    using BankSystem;
    using Interfaces;

    public class DepositAccount : Accounts, IDeposit, IWithdraw
    {

        public DepositAccount(double balance, double interestRate, CustomerTypes customer) : base(balance, interestRate, customer) { }

        public override double CalculateInterest(int months)
        {
            if (months <= 0)
            {
                return 0;
            }

            Console.WriteLine("{0} calculate interest - for {1} months, for customer {2} :",this.GetType().Name, months, this.CustomerType);
            if (this.Balance < 1000)
            {
                return 0;
            }

            return this.Balance * (1 + this.InterestRate * months);
        }

        public double Withdraw(double amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("You cannot withdraw more than your current balance : " + this.Balance);
            }

            Console.WriteLine("Withdraw {0} successfully", amount);
            this.Balance -= amount;
            return amount;
        }
    }
}

