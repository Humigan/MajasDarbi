using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, SeatsInACar, drivers, passengers, CarsNotDriven, cars_driven;
            double CarpoolCapacity, AveragePassengersPerCar;

            cars = 100; //cars
            SeatsInACar = 4; //seats in a car
            drivers = 28; // drivers
            passengers = 90; // passengers
            CarsNotDriven = 10;
            //cars_driven ; // cars driven at the moment
            CarpoolCapacity = 5;
            AveragePassengersPerCar = 7.5;


            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + CarsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + CarpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + AveragePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}