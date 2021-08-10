using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            bool w = false;

            foreach (var i in colors)
            {
                if (i == "White")
                {
                    w = true;
                    break;
                }
                else 
                {
                    w = false;
                }
            }
            Console.WriteLine("In this list there is a White element? " + w);
        }
    }
}
