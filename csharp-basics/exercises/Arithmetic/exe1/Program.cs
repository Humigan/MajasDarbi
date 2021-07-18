using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            bool Either = false;

            if (a == 15 || b == 15 || a + b == 15 || a - b == 15 || b - a == 15)
            {
                Either = true;
            }
            Console.WriteLine(Either);
        }
    }
}