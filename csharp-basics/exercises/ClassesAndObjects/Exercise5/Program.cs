using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var DateTest = new Date(09, 01, 2000);
            DateTest.DisplayDate();
            DateTest.SetYear(1970);
            DateTest.DisplayDate();
            DateTest.SetMonth(9);
            DateTest.DisplayDate();
            DateTest.SetDay(19);
            DateTest.DisplayDate();
        }
    }
}
