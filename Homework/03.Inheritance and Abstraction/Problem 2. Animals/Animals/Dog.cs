namespace Problem02.Animals
{
    using System;

    public class Dog : Animals
    {
        public Dog(string gender, int age, string name) : base(gender, age, name) { }

        public override void ProduceSound()
        {
            Console.WriteLine("Bark bark");
        }
    }
}
