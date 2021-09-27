using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string text;
            text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z')
                {
                    count++;
                }
            }
            Console.WriteLine("The number of the uppercase letters is " + count);
        }
    }
}