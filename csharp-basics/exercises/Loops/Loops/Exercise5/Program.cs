using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string FirstWord = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            string SecondWord = Console.ReadLine();
            Console.Write(FirstWord);
            int count = 30 - FirstWord.Length - SecondWord.Length;
            for (int i = 0; i < count; i++)
            {
                Console.Write(".");
            }
            Console.Write(SecondWord);
        }
    }
}
