using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 111; i++)
            {
                if (i % 5 == 0 && i % 7 == 0 && i % 3 == 0)
                {
                    Console.Write(" CozaLozaWoza");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" CozaLoza");
                }
                else if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write(" CozaWoza");
                }
                else if (i % 5 == 0 && i % 7 == 0)
                {
                    Console.Write(" LozaWoza");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(" Coza");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" Loza");
                }
                else if (i % 7 == 0)
                {
                    Console.Write(" Woza");
                }
                else
                {
                    Console.Write(" " + i);
                }
                if (i % 11 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}