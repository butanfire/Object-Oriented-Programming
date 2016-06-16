namespace Problem02.Animals
{
    using System;

    public class Frog : Animals
    {
        public Frog(string gender, int age, string name) : base(gender, age, name) { }

        public override void ProduceSound()
        {
            Console.WriteLine("Wabbbaa");
        }
    }
}
