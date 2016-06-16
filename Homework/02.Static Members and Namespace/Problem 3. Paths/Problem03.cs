using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Problem03
    {
        static void Main(string[] args)
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
