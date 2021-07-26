namespace FuelConsumptionCalculator
{
    public class Car
    {
        double _startOdo;
        double _endingOdo;
        double _liters;

        public Car(double startOdo, double endingOdo, double liters)
        {
            _startOdo = startOdo;
            _endingOdo = endingOdo;
            _liters = liters;
        }

        public Car(double startOdo)
        {
            _startOdo = startOdo;
        }

        public double CalculateConsumption()
        {
            return (_endingOdo - _startOdo) / _liters; //l par 1 km;
        }

        private double ConsumptionPer100Km()
        {
            return (_liters / (_endingOdo - _startOdo)) * 100;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _endingOdo = mileage;
            _liters = liters;
        }
    }
}
