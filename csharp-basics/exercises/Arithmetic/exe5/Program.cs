using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Random rnd = new Random();
            int num = rnd.Next(1, 100);
            Console.WriteLine("I'm thinking of a number between 1-100.");

            a = int.Parse(Console.ReadLine());
            if (num == a)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");

            }
            else if (a > num)
            {
                Console.WriteLine("Sorry, you are too high.  I was thinking of " + num);
            }
            else
            {
                Console.WriteLine("Sorry, you are too low.  I was thinking of " + num);
            }
        }
    }
}