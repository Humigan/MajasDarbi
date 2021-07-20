using System;

namespace exe10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            int choice;
            Console.WriteLine("1)Calculate the Area of a Circle");
            Console.WriteLine("2)Calculate the Area of a Rectangle");
            Console.WriteLine("3)Calculate the Area of a Triangle");
            Console.WriteLine("4)Quit");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Radius");
                    a = double.Parse(Console.ReadLine());
                    c = Math.PI * a * 2;
                    Console.WriteLine("Radius of a circle is " + c);
                    break;
                case 2:
                    Console.WriteLine("Enter Length");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Width");
                    b = double.Parse(Console.ReadLine());
                    c = a * b;
                    Console.WriteLine("Area of the rectangle is " + c);
                    break;
                case 3:
                    Console.WriteLine("Enter Base");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Height");
                    b = double.Parse(Console.ReadLine());
                    c = a * b * 0.5;
                    Console.WriteLine("Area of a Triangle is " + c);
                    break;
                default:
                    Console.WriteLine("ERROR INCORRECT NUMBER");
                    break;
            }
        }
    }
}