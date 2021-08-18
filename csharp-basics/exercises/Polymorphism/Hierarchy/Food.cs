using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Food
    {
        private int _count;

        public Food(int count)
        {
            _count = count;
        }
    }
}
