using System;

namespace exe9
{
    class Program
    {
        static void BMI(double w, double h)
        {
            double BM;
            BM = w * 703 / Math.Pow(h, 2);
            Console.WriteLine("Your BMI is " + BM);
            if (BM > 25)
            {
                Console.WriteLine("Overweight");
            }
            else if (BM < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else
            {
                Console.WriteLine("Optimal");
            }
        }

        static void Main(string[] args)
        {
            BMI(110, 68.9);
            BMI(161, 68.9);
            BMI(190, 68.9);
        }
    }
}