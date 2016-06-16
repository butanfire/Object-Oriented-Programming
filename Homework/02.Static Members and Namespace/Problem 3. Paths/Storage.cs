namespace Problem_3.Paths
{
    using Problem01.Point3D;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class Storage
    {
        public static Path3D LoadPaths(string filename)
        {
            Path3D pointSequence = new Path3D(new List<Point>());
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] argument = line.Split(',');
                        Point testP = new Point(int.Parse(argument[0]), int.Parse(argument[1]),int.Parse(argument[2]));
                        pointSequence.AddPoint(testP);
                    }                    
                }                
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:" + e.Message);                
            }
            
            return pointSequence;
        }

        public static void SavePaths(Path3D SavePoints,string filename)
        {
            string tempWrite;
            try
            {
                using (StreamWriter sr = new StreamWriter(filename))
                {
                    foreach(Point s in SavePoints.Points)
                    {
                        sr.WriteLine(tempWrite = s.ToString());
                    }                                      
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
