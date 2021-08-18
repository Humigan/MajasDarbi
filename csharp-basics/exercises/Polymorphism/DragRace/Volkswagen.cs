using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    class Volkswagen : ICar, Nitro
    {
        private int currentSpeed = 0;
        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void SlowDown()
        {
            currentSpeed--;
        }

        public void SpeedUp()
        {
            currentSpeed++;
        }

        public void StartEngine()
        {
            Console.WriteLine("RARARA");
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed++;
            currentSpeed++;
        }
    }
}
