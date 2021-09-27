using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.exe1.Test
{
    public class Polymorphism_exe1
    {
        private static int currentSpeed = 0;

        public int SpeedUp()
        {
            ++currentSpeed;
            return currentSpeed;
        }

        public int SlowDown()
        {
            currentSpeed--;
            return currentSpeed;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public int UseNitrousOxideEngine()
        {
            ++currentSpeed;
            ++currentSpeed;
            return currentSpeed;
        }
    }
}
