using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minutes: ");
            double min;
            double year;
            double day;
            min = int.Parse(Console.ReadLine());
            year = min / 525600;
            day = min / 1440;
            Console.WriteLine("Years in minute " + year);
            Console.WriteLine("Days in minute " + day);
        }
    }
}