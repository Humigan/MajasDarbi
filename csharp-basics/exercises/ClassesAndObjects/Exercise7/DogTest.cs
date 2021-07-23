using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var Max = new Dog("Max", "Male");
            var Rocky = new Dog("Rocky", "Male");
            var Sparky = new Dog("Sparky", "Male");
            var Buster = new Dog("Buster", "Male");
            var Sam = new Dog("Sam", "Male");
            var Lady = new Dog("Lady", "Female");
            var Molly = new Dog("Molly", "Female");
            var Coco = new Dog("Coco", "Female");

            Max.Mother(Lady);
            Max.Father(Rocky);
            Coco.Mother(Molly);
            Coco.Father(Buster);
            Rocky.Mother(Molly);
            Rocky.Father(Sam);
            Buster.Mother(Lady);
            Buster.Father(Sparky);

            Console.WriteLine(Coco.fathersName());
            Console.WriteLine(Sparky.fathersName());

            Console.WriteLine(Coco.HasSameMotherAs(Rocky));
            Console.WriteLine(Max.HasSameMotherAs(Rocky));
        }
    }
}
