using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers?");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                if (i%3 == 0 && i%5 == 0)
                {
                  Console.Write("FizzBuzz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else 
                {
                    Console.Write(i + " ");
                }

                if (i%20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
