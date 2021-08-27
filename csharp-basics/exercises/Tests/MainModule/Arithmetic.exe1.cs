using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic.exe1.Test
{
    public static class Arithmetic_exe1
    {
        public static bool is15(int a, int b) 
        {
            if (a == 15 || b == 15 || a + b == 15 || a - b == 15 || b - a == 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
