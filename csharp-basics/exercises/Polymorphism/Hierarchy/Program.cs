using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Cat();
            var b = new Tiger();
            var c = new Zebra();
            var d = new Mouse();
            List<Animal> arr = new List<Animal>();
            arr.Add(a);
            arr.Add(b);
            arr.Add(c);
            arr.Add(d);

            foreach (var item in arr)
            {
                item.animalName = Console.ReadLine();
                Console.Write(item.animalName + " ");
                item.animalWeight = int.Parse(Console.ReadLine());
                Console.WriteLine(item.animalWeight + " ");
                item.Eat(new Vegetable(5));
                item.MakeSound();
            }


        }
    }
}