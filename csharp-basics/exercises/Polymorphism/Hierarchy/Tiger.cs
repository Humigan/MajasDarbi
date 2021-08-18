using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Tiger : Felime
    {
        private string _livingRegion;
        public override void Eat(Food a)
        {
            if (a.ToString() == "Hierarchy.Meat")
            {
                Console.WriteLine("{AnimalType} are eating that type of food!");
            }
            else
            {
                Console.WriteLine("{AnimalType} are NOT eating that type of food!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Argrrgrg");
        }

        public string livingRegion
        {
            get { return _livingRegion; }
            set { _livingRegion = value; }
        }
    }
}
