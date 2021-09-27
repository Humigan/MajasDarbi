using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num;
            string cont;
            Random rnd = new Random();
            Console.WriteLine("Welcome to Piglet!");
            for (int i = 0; i < 999; i++)
            {
                num = rnd.Next(1, 6);
                sum += num;
                Console.WriteLine("You rolled a " + num);
                if (num == 1)
                {
                    Console.WriteLine("You got 0 points.");
                    break;
                }

                Console.Write("Continue? y/n ");
                cont = Console.ReadLine();
                if (cont == "y")
                {
                    num = rnd.Next(1, 6);
                    sum += num;
                    Console.WriteLine("You rolled a " + num);
                    if (num == 1)
                    {
                        Console.WriteLine("You got 0 points.");
                        break;
                    }
                    Console.Write("Continue? y/n ");
                    cont = Console.ReadLine();
                }
                else if (cont == "n")
                {
                    Console.WriteLine("You got "+ sum +" points.");
                    break;
                }
                else 
                {
                    break;
                }
            }

                
           
        }
    }
}
