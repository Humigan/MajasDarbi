using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.exe8.Test
{
    public static class Collections_exe8
    {
        public static List<string> SortList()
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            Console.Write("List before sort: ");
            Console.WriteLine(string.Join(",", colors));

            colors.Sort();

            return colors;

            Console.Write("List after sort: ");
            Console.WriteLine(string.Join(",", colors));
        }
    }
}