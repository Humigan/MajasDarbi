using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe8
{

    class Program
    {
        static void Salary(double hours, double BasePay)
        {
            double overwork;
            double sal;
            if (hours > 60)
            {
                Console.WriteLine("ERROR TO MUCH HOURS");
            }
            else if (BasePay < 8)
            {
                Console.WriteLine("ERROR TO LOW Base Pay");
            }
            else if (hours > 40 && hours < 60)
            {
                overwork = hours - 40;
                sal = 40 * BasePay;
                sal = (BasePay * 1.5) * overwork + sal;
                Console.WriteLine("Youe Salary is " + sal);
            }
            else
            {
                sal = hours * BasePay;
                Console.WriteLine("Youe Salary is " + sal);
            }

        }

        static void Main(string[] args)
        {
            Salary(35, 7.5);
            Salary(47, 8.2);
            Salary(73, 10);
        }
    }
}