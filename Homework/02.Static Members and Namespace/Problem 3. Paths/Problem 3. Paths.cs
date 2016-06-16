namespace Problem_3.Paths
{
    using System;

    public class MainClass
    {
        public static void Main(string[] args)
        {
            string filenameLoad = @"points.txt"; //path is \Problem03\bin\Debug
            Path3D pointOutput = Storage.LoadPaths(filenameLoad);
            string output = pointOutput.ToString();
            Console.WriteLine(output); //output the points

            string filenameSave = @"blank.txt"; //path is \Problem03\bin\Debug
            Storage.SavePaths(pointOutput, filenameSave);
        }
    }
}
