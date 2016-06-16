namespace AsyncTimer
{
    using System;
    using System.Threading;

    public class Program
    {
        static void Main(string[] args)
        {
            Action<int> someAction = number => Console.WriteLine(number); //output a number
            Async output = new Async(someAction, 5, 1000); //assign the function , ticks , interval
            output.SomeAction += execution => {
                someAction(execution); //calling the initial function again
                Console.WriteLine("Executed {0} times", execution); //writing something
            };

            for (int i = 1; i <= output.Ticks; i++)
            {
                output.SomeAction(i); //output the iterator 2 times + Execution output
                Thread.Sleep(output.TimeInterval); //ZzzZzzz
            }
        }
    }
}
