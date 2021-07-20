using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            double input1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            double input2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            double input3 = double.Parse(Console.ReadLine());

            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine("1st input the largest: " + input1);
            }
            else if (input2 > input1 && input2 > input3)
            {
                Console.WriteLine("2nd input the largest: " + input2);
            }
            else (input3 > input1 && input3 > input2)
            {
                Console.WriteLine("3rd input the largest: " + input3);
            }
        }
    }
}
