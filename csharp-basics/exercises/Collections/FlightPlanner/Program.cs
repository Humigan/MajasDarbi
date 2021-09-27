using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "C:/Users/Humigan/Source/Repos/Humigan/MajasDarbi/csharp-basics/exercises/Collections/FlightPlanner/flights.txt";
        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                Console.WriteLine(s);
            }
        }
	}
}
