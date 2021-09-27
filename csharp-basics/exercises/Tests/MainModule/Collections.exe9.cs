using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.exe9.Test
{
    public static class Collections_exe9
    {
        public static List<string> JoinList()
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(",", firstList));

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine(string.Join(",", secondList));

            firstList.AddRange(secondList);
            return firstList;
            Console.WriteLine(string.Join(",", firstList));
        }
    }
}