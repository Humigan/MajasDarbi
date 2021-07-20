using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, result = 0;
            double count = 0;
            double ave;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (double i = a; i <= b + 1; i++)
            {
                result += i;
                count++;
            }
            ave = result / count;
            Console.WriteLine(result);
            Console.WriteLine((double)ave);
        }
    }
}