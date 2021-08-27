using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic.exe6.Test
{
    public static class Arithmetic_exe6
    {
        public static string CozaLozaWoza(int a)
        {
            if (a % 5 == 0 && a % 7 == 0 && a % 3 == 0)
            {
                return "CozaLozaWoza";
            }
            else if (a % 3 == 0 && a % 5 == 0)
            {
                return "CozaLoza";
            }
            else if (a % 3 == 0 && a % 7 == 0)
            {
                return "CozaWoza";
            }
            else if (a % 5 == 0 && a % 7 == 0)
            {
                return "LozaWoza";
            }
            else if (a % 3 == 0)
            {
                return "Coza";
            }
            else if (a % 5 == 0)
            {
                return "Loza";
            }
            else if (a % 7 == 0)
            {
                return "Woza";
            }
            else 
            {
                return "Error";
            }
        }
    }
}