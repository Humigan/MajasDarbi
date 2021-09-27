using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sum, a, b;
            Console.Write("Desired sum: ");
            sum = int.Parse(Console.ReadLine());
            for (int i = 0; i < 999; i++)
            {
                a = rnd.Next(1, 6);
                b = rnd.Next(1, 6);
                Console.WriteLine(a + " and " + b + " = " + (a+b));
                if (a+b == sum)
                {
                    break;
                }
            }
        }
    }
}
