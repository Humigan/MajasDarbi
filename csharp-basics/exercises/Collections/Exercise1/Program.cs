using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> cars = array.ToList();
            Console.WriteLine(string.Join(",", cars));

            var HasArr = new HashSet<string>(array);
            foreach (var item in HasArr)
            {
                Console.WriteLine(item);
            }

            var DicArr = new Dictionary<int, string>();
            for (int i = 0; i < array.Length; i++)
            {
                DicArr.Add(i, array[i]);
            }
            ICollection<int> keys = DicArr.Keys;
            foreach (int j in keys)
            {
               Console.WriteLine("ID -> {0}  Name -> {1}", j, DicArr[j]);
            }
        }
    }
}
