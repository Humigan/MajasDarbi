using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            
            Console.WriteLine("Input number of terms : ");

            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input number TO terms : ");

            i = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine(Pow(i,n));

            Console.ReadKey();
        }

        static int Pow(int number, int times)
        {
            int a = number;
            for (int i = 0; i < times; i++)
            {
                a *=number;
            }
            return a;
        }
    }
}
