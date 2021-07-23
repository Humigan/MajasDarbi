using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How much money is in the account?: ");
            int start = int.Parse(Console.ReadLine());
            var Person = new SavingsAccount(start);
            Console.WriteLine("Enter the annual interest rate: ");
            int inter = int.Parse(Console.ReadLine());
            Console.WriteLine("How long has the account been opened? ");
            int month = int.Parse(Console.ReadLine());
            Person.Interest(inter, month);

        }
    }
}
