using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Point
    {
        int x;
        int y;

      public Point(int x,int y) 
        {
            this.x = x;
            this.y = y;
        }

        public void SwapPoint(ref Point a, ref Point b) 
        {
            int temp;
            int temp2;
            temp = a.x;
            temp2 = a.y;
            a.x = b.x;
            a.y = b.y;
            b.x = temp;
            b.y = temp2;
        }

        public void ShowPoint(Point a, Point b) 
        {
            Console.WriteLine("Point 1 x = " + a.x);
            Console.WriteLine("Point 1 y = " + a.y);
            Console.WriteLine("Point 2 x = " + b.x);
            Console.WriteLine("Point 2 y = " + b.y);
        }
    }
}
