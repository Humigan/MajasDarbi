using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        private const string Path = "C:/Users/Humigan/Source/Repos/Humigan/MajasDarbi/csharp-basics/exercises/Collections/WordCount/lear.txt";
        static void Main(string[] args)
        {
            int WordsCount = 0;
            int CharCount = 0;
            int LinesCount = 0;
            string FileText = new System.IO.StreamReader(Path).ReadToEnd().Replace("\r\n", "\r");
            CharCount = FileText.Length;            //total char 
            LinesCount = FileText.Split('\r').Length;       //total lines
            WordsCount = FileText.Split(' ').Length;        // total Words
            Console.WriteLine("Lines = " + LinesCount);
            Console.WriteLine("Words = " + WordsCount);
            Console.WriteLine("Chars = " + CharCount);
        }
    }
}
