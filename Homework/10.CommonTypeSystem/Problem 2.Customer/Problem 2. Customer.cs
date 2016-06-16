namespace Customer
{
    using System;
    using Models;

    public class CustomerMain
    {
        public static void Main(string[] args)
        {
            
            Models.Customer cust1 = new Models.Customer("Peter", "Marinated", "Thompson", "333555333", "Whales Str. 33", "peter@facebook.com", "+359888743", CustomerTypes.Diamond);
            Models.Customer cust2 = new Models.Customer("Peter", "Marinated", "Ivanov", "333555333", "Thompson Str. 33", "gosho@facebook.com", "+359888756", CustomerTypes.Diamond);

            cust1.AddPayment(new Payment("stuff", 200));
            cust1.AddPayment(new Payment("Utilities", 100));
            
            cust2.AddPayment(new Payment("telefon", 100));
            cust2.AddPayment(new Payment("voda", 150));

            Console.WriteLine(cust1== cust2);//compare them by ID and check whether they are equal

            var cust3 = (Models.Customer)cust2.Clone();

            cust3.AddPayment(new Payment("Kola", 5444));
            cust3.AddPayment(new Payment("Apartment", 99999));

            Console.WriteLine(cust3);
            Console.WriteLine(cust2);

            // Compare Cutomers
            Console.WriteLine(cust2.CompareTo(cust1));
        }
    }
}
