using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            Console.ReadKey();
        }

        static void first()
        {

            String a = "1";
            int b = 2;
            int c = 3;
            double d = 4;
            float e = 5;
            double f;
            double.TryParse(a, out f);
            double sum;
            sum = f + b + c + d + e;


            //fixme - should be 15 :|

            Console.WriteLine(sum);
        }

        static void second()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            float d = 4.2f;
            float e = 5.3f;
            float f;
            float.TryParse(a, out f);
            float sum;

            //fixme - should be 15.5 :| 
            sum = f + b + c + d + e;
            Console.WriteLine(sum);
        }
    }
}