using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string path = "C:/Users/Humigan/Source/Repos/Humigan/MajasDarbi/csharp-basics/exercises/Collections/Histogram/midtermscores.txt";
        private static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("C:/Users/Humigan/Source/Repos/Humigan/MajasDarbi/csharp-basics/exercises/Collections/Histogram/midtermscores.txt"))
            {
                string line;
                int[] arr = new int[12];
                while ((line = sr.ReadLine()) != null)
                {
                    string[] text = line.Split(' ');
                    int[] MyArr = new int[text.Length];
                    for (int i = 0; i < text.Length; i++)
                    {
                        MyArr[i] = Convert.ToInt32(text[i]);
                    }
                    for (int i = 0; i < MyArr.Length; i++)
                    {
                        if (MyArr[i] > 0&& MyArr[i] <= 9)
                        {
                            arr[0]++;
                        }
                        else if (MyArr[i] >= 10&& MyArr[i] <= 19)
                        {
                            arr[1]++;
                        }
                        else if (MyArr[i] >= 20 && MyArr[i] <= 29)
                        {
                            arr[2]++;
                        }
                        else if (MyArr[i] >= 30 && MyArr[i] <= 39)
                        {
                            arr[3]++;
                        }
                        else if (MyArr[i] >= 40 && MyArr[i] <= 49)
                        {
                            arr[4]++;
                        }
                        else if (MyArr[i] >= 50 && MyArr[i] <= 59)
                        {
                            arr[5]++;
                        }
                        else if (MyArr[i] >= 60 && MyArr[i] <= 69)
                        {
                            arr[6]++;
                        }
                        else if (MyArr[i] >= 70 && MyArr[i] <= 79)
                        {
                            arr[7]++;
                        }
                        else if (MyArr[i] >= 80 && MyArr[i] <= 89)
                        {
                            arr[8]++;
                        }
                        else if (MyArr[i] >= 90 && MyArr[i] <= 99)
                        {
                            arr[9]++;
                        }
                        else
                        {
                            arr[10]++;
                        }
                    }
                    Console.Write("0 - 9: ");
                    for (int i = 0; i < arr[0]; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("10 - 19: ");
                    for (int i = 0; i < arr[1]; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("20 - 29: ");
                    for (int i = 0; i < arr[2]; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("30 - 39: ");
                    for (int i = 0; i < arr[3]; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("40 - 49: ");
                    for (int i = 0; i < arr[4]; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("50 - 59: ");
                    for (int i = 0; i < arr[5]; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("60 - 69: ");
                    for (int i = 0; i < arr[6]; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("70 - 79: ");
                    for (int i = 0; i < arr[7]; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("80 - 89: ");
                    for (int i = 0; i < arr[8]; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("90 - 99: ");
                    for (int i = 0; i < arr[9]; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("100: ");
                    for (int i = 0; i < arr[10]; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
    
