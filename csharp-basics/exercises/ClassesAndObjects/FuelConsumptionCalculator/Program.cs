using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;

            
            Console.WriteLine();

            Car car = new Car(0,0,0);
            Car car1 = new Car(0,0,0);
            Console.WriteLine(car.CalculateConsumption() + "km per L");
            Console.WriteLine(car1.CalculateConsumption()+ "km per L");
            Console.WriteLine(car.GasHog());
            Console.WriteLine(car1.GasHog());
            Console.WriteLine(car.EconomyCar());
            Console.WriteLine(car1.EconomyCar());

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Car Enter first reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Car Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car.FillUp(startKilometers, liters);
                
                Console.Write("Car 1 Enter first reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Car 1 Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car1.FillUp(startKilometers, liters);
            }

            Console.WriteLine("Kilometers per liter are " + car.CalculateConsumption() + " gasHog:" + car.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption()+ " economyCar:" + car1.EconomyCar());
            Console.ReadKey();
        }
    }
}
