using System;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var Audi = new Audi();
            var Bmw = new Bmw();
            var Lexus = new Lexus();
            var Saab = new Saab();
            var Tesla = new Tesla();
            var Volkswagen = new Volkswagen();

            ICar[] CarList = {Audi,Bmw,Lexus,Saab,Tesla,Volkswagen};
            int count = 0;

            for (int i = 0; i < CarList.Length; i++)
            {
                if(i == CarList.Length - 1) 
                {
                    i = 0;
                    count++;
                    if(count == 11)
                    {
                        break;
                    }
                }

                CarList[i].SpeedUp();

                if(count == 3)
                {
                    Volkswagen.UseNitrousOxideEngine();
                    Lexus.UseNitrousOxideEngine();
                    count++;
                }
            }

            string fastestName = CarList[0].ToString();
            string fastestSpeed = CarList[0].ShowCurrentSpeed();

            for (int i = 0; i < CarList.Length; i++)
            {
             if(Convert.ToInt32(fastestSpeed) <= Convert.ToInt32(CarList[i].ShowCurrentSpeed())) 
                {
                    fastestName = CarList[i].ToString();
                    fastestSpeed = CarList[i].ShowCurrentSpeed();
                }
            }

            Console.WriteLine("The fastest car is " + fastestName + " the speed is " + fastestSpeed);
        }
    }
}