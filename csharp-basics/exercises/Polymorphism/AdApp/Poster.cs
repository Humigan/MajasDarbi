using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdApp
{
    class Poster : Advert
    {
        private int _dimensions;
        private int _numCopies;
        private int _costPerCopy;

        public Poster(int fee, int dimensions, int numCopies, int costPerCopy) : base(fee)
        {
            _dimensions = dimensions;
            _numCopies = numCopies;
            _costPerCopy = costPerCopy;
        }

        public new int Cost()
        {
            var sum = base.Cost() + (_numCopies * _costPerCopy)*_dimensions;
            return sum;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
