using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            for (int i = 0; i < 999; i++)
            {
                Console.WriteLine("Enter number to check it is even or odd");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    Console.WriteLine("Even Number");
                }
                if (a % 2 == 1)
                {
                    Console.WriteLine("Odd Number");
                }

                Console.WriteLine("Continue?");
                Console.WriteLine("1 - yes / 2 - no");
                b = int.Parse(Console.ReadLine());
                if (b == 1)
                {
                    continue;
                }
                if (b == 2)
                {
                    break;
                }
                if (b != 1 || b != 2)
                {
                    Console.WriteLine("ERROR");
                    break;
                }
            }
            Console.WriteLine("bye!");
        }
    }
}