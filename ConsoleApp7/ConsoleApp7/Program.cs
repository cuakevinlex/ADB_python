using System;
using System.IO;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            // astroCalculations parameters are pythonPath, astroFilePath, decFilePath
            string pythonPath = @"C:\Users\cuake\AppData\Local\Programs\Python\Python39\python.exe";

            string astroPath = @"C:\Users\cuake\Downloads\Astroplan_calculations.py";
            //string astroPath = @"Astroplan_calculations.py";

            string decPath = @"C:\Users\cuake\Downloads\Declination_limit_of_location.py";
            //string decPath = @"Declination_limit_of_location.py";
            if (!File.Exists(pythonPath))
            {
                //create the log
                Console.WriteLine("pythonPath does not exists");
            }
            if (!File.Exists(decPath))
            {
                //create the log
                Console.WriteLine("DecFile does not exists");
            }
            if (!File.Exists(astroPath))
            {
                //create the log
                Console.WriteLine("AstroFile does not exists");
            }

            AstroCalculations p = new AstroCalculations(pythonPath, astroPath, decPath);
            // returns array of string containing startTime and endTime
            string[] astroResults = p.AstroplanCalculations(19.825, -155.4761, 4200, 20, 90.752, -16.716);
            Console.WriteLine("{0} {1}", astroResults[0], astroResults[1]);

            // returns string of decLimit
            Console.WriteLine(p.Declinationlimit(120, -24, 50, 10));
        }

    }
}
