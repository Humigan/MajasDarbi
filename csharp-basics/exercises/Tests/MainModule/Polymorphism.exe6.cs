using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.exe6.Test
{
    public class Polymorphism_exe6
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;
        private string _livingRegion;

        public string animalName
        {
            get { return _animalName; }
            set { _animalName = value; }
        }

        public string animalType
        {
            get { return _animalType; }
            set { _animalType = value; }
        }

        public double animalWeight
        {
            get { return _animalWeight; }
            set { _animalWeight = value; }
        }

        public string LivingRegion
        {
            get { return _livingRegion; }
            set { _livingRegion = value; }
        }
    }
}