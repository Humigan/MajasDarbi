using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Cat : Felime
    {
        private string _breed;
        public override void Eat(Food a)
        {
            Console.WriteLine("{AnimalType} are eating that type of food!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowww");
        }

        public string breed
        {
            get { return _breed; }
            set { _breed = value; }
        }

    }
}
