using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Write 3 numbers");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            double sum;
            sum = a + b + c;
            Console.WriteLine("The sum of 3 numbers is " + sum);
        }
    }
}