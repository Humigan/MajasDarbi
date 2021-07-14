using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe9
{
    class Program
    {
        static void Main(string[] args)
        {
            double metrs, hour, min, sec, ms, kmh, milh;
            Console.WriteLine("Input distance in meters:");
            metrs = double.Parse(Console.ReadLine());
            Console.WriteLine("Input hour:");
            hour = double.Parse(Console.ReadLine());
            Console.WriteLine("Input minutes:");
            min = double.Parse(Console.ReadLine());
            Console.WriteLine("Input seconds:");
            sec = double.Parse(Console.ReadLine());
            Console.WriteLine("Expected Output:");
            ms = metrs / ((hour * 60 * 60) + (min * 60) + sec);
            Console.WriteLine("Your speed in meters/second is " + ms);
            kmh = (metrs / 1000) / (hour + (min / 60) + (sec / 60 / 60));
            Console.WriteLine("Your speed in km/h is " + kmh);
            milh = (metrs * 0.000621371192) / ((hour + (min / 60) + (sec / 60 / 60)));
            Console.WriteLine("Your speed in miles/h is " + milh);
        }
    }
}