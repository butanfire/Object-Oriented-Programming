namespace Problem2_BankOfKurtovoKonare
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BankSystem;
    using CustomerAccounts;

    public class BankOfKurtovoKonare
    {
        public static void Main(string[] args)
        {
            List<Accounts> output = new List<Accounts>();

            output.Add(new DepositAccount(1000, 10.5, CustomerTypes.Individuals));
            output.Add(new DepositAccount(5000, 10.5, CustomerTypes.Companies));
            output.Add(new LoanAccount(1000, 3.5, CustomerTypes.Companies));
            output.Add(new LoanAccount(1000, 4.5, CustomerTypes.Individuals));
            output.Add(new MortgageAccount(4000, 9.0, CustomerTypes.Companies));
            output.Add(new MortgageAccount(3200, 6.5, CustomerTypes.Individuals));

            var DepositList = output.Where(s => s.GetType().Name.ToString() == "DepositAccount").ToList();

            foreach (DepositAccount s in DepositList)
            {
                Console.WriteLine(s.ToString());
                s.Deposit(200);
                Console.WriteLine(s.ToString());
                Console.WriteLine(s.CalculateInterest(10));
                s.Withdraw(400);
                Console.WriteLine(s.ToString());
                Console.WriteLine(s.CalculateInterest(10));
                Console.WriteLine();
            }

            Console.WriteLine(new string('=', 100));

            foreach (Accounts s in output)
            {
                Console.Write(s.ToString());
                Console.WriteLine();
                Console.WriteLine(s.CalculateInterest(5));
                Console.WriteLine(s.CalculateInterest(12));
            }
        }
    }
}
