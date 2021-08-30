using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic.exe8.Test
{
    public static class Arithmetic_exe8
    {
        public static double CalculateSalary(double hours, double BasePay)
        {
            double overwork;
            double sal;
            if (hours > 60)
            {
                Console.WriteLine("ERROR TO MUCH HOURS");
                return 0;
            }
            else if (BasePay < 8)
            {
                Console.WriteLine("ERROR TO LOW Base Pay");
                return 0;
            }
            else if (hours > 40 && hours < 60)
            {
                overwork = hours - 40;
                sal = 40 * BasePay;
                sal = (BasePay * 1.5) * overwork + sal;
                return sal;
                Console.WriteLine("Your Salary is " + sal);
            }
            else
            {
                sal = hours * BasePay;
                return sal;
                Console.WriteLine("Your Salary is " + sal);
            }
        }
    }
}