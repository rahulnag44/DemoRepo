using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing something from a config file...");
            string s = ConfigurationManager.AppSettings["superman"].ToString();

            Console.WriteLine("What I got from the config file is: " + s);
            Console.WriteLine("Adding something extra just to see what happens...");
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
