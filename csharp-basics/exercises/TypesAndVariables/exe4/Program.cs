using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int year;
            Console.WriteLine("Enter you name");
            name = Console.ReadLine();
            Console.WriteLine("Enter you year of born");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("My name is " + name + " and I was born in " + year + ".");

        }
    }
}