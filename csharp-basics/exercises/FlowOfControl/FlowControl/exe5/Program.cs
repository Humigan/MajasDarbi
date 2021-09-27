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
            Console.WriteLine("Write a sentence");
            string text = Console.ReadLine();
            string text2 = text.ToLower();
            text2.ToString();
            

            for (int i = 0; i < text2.Length; i++)
            {
                switch (text2)
                {
                    case "a":
                    case "b":
                    case "c":
                        Console.WriteLine(2); 
                        break;
                    case "d":
                    case "e":
                    case "f":
                        Console.WriteLine(3);
                        break;
                    case "g":
                    case "h":
                    case "i":
                        Console.WriteLine(4);
                        break;
                    case "j":
                    case "k":
                    case "l":
                        Console.WriteLine(5);
                        break;
                    case "m":
                    case "n":
                    case "o":
                        Console.WriteLine(6);
                        break;
                    case "p":
                    case "q":
                    case "r":
                    case "s":
                        Console.WriteLine(7);
                        break;
                    case "t":
                    case "u":
                    case "v":
                        Console.WriteLine(8);
                        break;
                    case "w":
                    case "x":
                    case "y":
                    case "z":
                        Console.WriteLine(9);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
