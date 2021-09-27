using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.exe5.Test
{
    public static class Collections_exe5
    {
        public static string ThirdElementChange(string color)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Violet",
                "White",
                "Black"
            };

            Console.WriteLine(string.Join(",", colors));

            colors.RemoveAt(2);
            colors.Insert(2, color);

            return colors[2];

            Console.WriteLine(string.Join(",", colors));
        }
    }
}
