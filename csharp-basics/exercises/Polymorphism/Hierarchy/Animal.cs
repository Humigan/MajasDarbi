using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    abstract class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;

        public abstract void MakeSound();

        public abstract void Eat(Food a);
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

        public int foodEaten
        {
            get { return _foodEaten; }
            set { _foodEaten = value; }
        }
    }
}
