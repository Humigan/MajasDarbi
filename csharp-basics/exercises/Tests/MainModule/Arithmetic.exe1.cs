using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic.exe1.Test
{
    public static class Arithmetic_exe1
    {
        public static bool Is15(int a, int b) 
        {
           bool result = a == 15 || b == 15 || a + b == 15 || a - b == 15 || b - a == 15 ? true : false;
           return result;
        }
    }
}
