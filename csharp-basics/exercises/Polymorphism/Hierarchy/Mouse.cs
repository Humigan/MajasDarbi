using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
     class Mouse : Mammal
    {
        public override void Eat(Food a)
        {
           if(a.ToString() == "Hierarchy.Meat") 
            {
                Console.WriteLine("{AnimalType} are NOT eating that type of food!");
            }
            else 
            {
                Console.WriteLine("{AnimalType} are eating that type of food!");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Piu-piu");
        }
    }
}
