using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
   abstract class Mammal : Animal
    {
        private string _livingRegion;
        public string livingRegion
        {
            get { return _livingRegion; }
            set { _livingRegion = value; }
        }

    }
}
