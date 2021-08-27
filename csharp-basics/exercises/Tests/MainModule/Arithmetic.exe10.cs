using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic.exe10.Test
{
    public static class Arithmetic_exe10
    {
        public static double CalculateArea(int choice, double a, double b)
        {
            double c = 0;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Radius");
                    c = Math.PI * a * 2;
                    return c;
                    Console.WriteLine("Radius of a circle is " + c);
                    break;
                case 2:
                    Console.WriteLine("Enter Length");
                    Console.WriteLine("Enter Width");
                    c = a * b;
                    return c;
                    Console.WriteLine("Area of the rectangle is " + c);
                    break;
                case 3:
                    Console.WriteLine("Enter Base");
                    Console.WriteLine("Enter Height");
                    c = a * b * 0.5;
                    return c;
                    Console.WriteLine("Area of a Triangle is " + c);
                    break;
                default:
                    Console.WriteLine("ERROR INCORRECT NUMBER");
                    return c;
                    break;
            }
        }
    }
}
