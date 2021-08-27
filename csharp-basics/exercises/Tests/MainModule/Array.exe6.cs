using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.exe6.Test
{
    public static class Array_exe6
    {
        public static int Array()
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
            int[] arr2 = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            arr[arr.Length - 1] = -7;
            Console.Write("Array 1: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Array 2: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            return arr[9];
        }
    }
}
