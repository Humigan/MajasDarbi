using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic.exe7.Test
{
    public static class Arithmetic_exe7
    {
        public static double Gravity(double gravity, double fallingTime, double initialPosition, double initialVelocity)
        {
          return 0.5 * gravity * Math.Pow(fallingTime, 2) + initialPosition + initialVelocity;
        }
    }
}
