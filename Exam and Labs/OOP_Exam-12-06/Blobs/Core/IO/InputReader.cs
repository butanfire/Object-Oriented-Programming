namespace Blobs.Core.IO
{
    using System;
    using Interfaces;

    public class InputReader : IInputReader
    {
        public string ReadLine()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}
