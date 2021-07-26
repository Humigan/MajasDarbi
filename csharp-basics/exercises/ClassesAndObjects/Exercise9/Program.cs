using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            p1.ShowPoint(p1, p2);
            p1.SwapPoint(ref p1, ref p2);
            p1.ShowPoint(p1, p2);
        }   
    }
}
