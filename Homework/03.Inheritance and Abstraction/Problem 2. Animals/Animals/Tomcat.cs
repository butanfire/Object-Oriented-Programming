namespace Problem02.Animals
{
    using System;

    class Tomcat : Animals
    {
        public Tomcat(string gender, int age, string name) : base(gender, age, name) { }

        public override void ProduceSound()
        {
            Console.WriteLine("Mquau");
        }
    }
}
