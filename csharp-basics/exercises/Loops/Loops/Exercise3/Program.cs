using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Which number you want to know? ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    Console.WriteLine("Position of number " + num + " is " + (i+1));
                }
            }
        }
    }
}
