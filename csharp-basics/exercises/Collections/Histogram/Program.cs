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
                int a = 0;
                int b = 0;
                int c = 0;
                int d = 0;
                int e = 0;
                int f = 0;
                int g = 0;
                int k = 0;
                int l = 0;
                int m = 0;
                int n = 0;

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
                            a++;
                        }
                        else if (MyArr[i] >= 10&& MyArr[i] <= 19)
                        {
                            b++;
                        }
                        else if (MyArr[i] >= 20 && MyArr[i] <= 29)
                        {
                            c++;
                        }
                        else if (MyArr[i] >= 30 && MyArr[i] <= 39)
                        {
                            d++;
                        }
                        else if (MyArr[i] >= 40 && MyArr[i] <= 49)
                        {
                            e++;
                        }
                        else if (MyArr[i] >= 50 && MyArr[i] <= 59)
                        {
                            f++;
                        }
                        else if (MyArr[i] >= 60 && MyArr[i] <= 69)
                        {
                            g++;
                        }
                        else if (MyArr[i] >= 70 && MyArr[i] <= 79)
                        {
                            k++;
                        }
                        else if (MyArr[i] >= 80 && MyArr[i] <= 89)
                        {
                            l++;
                        }
                        else if (MyArr[i] >= 90 && MyArr[i] <= 99)
                        {
                            m++;
                        }
                        else
                        {
                            n++;
                        }
                    }
                    Console.Write("0 - 9: ");
                    for (int i = 0; i < a; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("10 - 19: ");
                    for (int i = 0; i < b; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("20 - 29: ");
                    for (int i = 0; i < c; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("30 - 39: ");
                    for (int i = 0; i < d; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("40 - 49: ");
                    for (int i = 0; i < e; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("50 - 59: ");
                    for (int i = 0; i < f; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("60 - 69: ");
                    for (int i = 0; i < g; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("70 - 79: ");
                    for (int i = 0; i < k; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("80 - 89: ");
                    for (int i = 0; i < l; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("90 - 99: ");
                    for (int i = 0; i < m; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Console.Write("100: ");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
    
