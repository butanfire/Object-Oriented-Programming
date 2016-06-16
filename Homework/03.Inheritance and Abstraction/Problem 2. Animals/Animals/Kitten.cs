namespace Problem02.Animals
{
    using System;

    public class Kitten : Animals
    {
        public Kitten(string gender,int age,string name) : base(gender, age, name) { }

        public override void ProduceSound()
        {
            Console.WriteLine("Myau");
        }
    }
}
