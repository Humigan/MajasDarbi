using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var Elements = new List<string>();
            Elements.Add("Eagle");
            Elements.Add("Bicycle");
            Elements.Add("Apple");
            Elements.Add("Canada");
            Elements.Add("Foobar");
            Elements.Add("Australia");
            Elements.Add("Mouse");
            Elements.Add("Teacher");
            Elements.Add("Cat");
            Elements.Add("Dog");
            Console.WriteLine(string.Join(",", Elements));
            
            Elements.Insert(5, "Green");
            Console.WriteLine(string.Join(",", Elements));

            Elements.RemoveAt(Elements.Count-1);
            Console.WriteLine(string.Join(",", Elements));

            Elements.Insert(Elements.Count-1,"House");
            Console.WriteLine(string.Join(",", Elements));

            Elements.Sort();
            Console.WriteLine(string.Join(",", Elements));

            bool f = false;
            foreach (var i in Elements)
            {
                if (i == "Foobar")
                {
                    f = true;
                }
            }
            Console.WriteLine("There is a Foobar word? " + f);

            foreach (var i in Elements)
            {
                Console.WriteLine(i);
            }
        }
    }
}
