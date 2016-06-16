namespace Problem02.Animals
{
    using System;

    public class Cat : Animals
    {
        public Cat(string gender, int age, string name) : base(gender, age, name) { }

        public override void ProduceSound()
        {
            Console.WriteLine("Mquu ");
        }
    }
}
