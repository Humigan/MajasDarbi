using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        string name;
        string sex;
        string mother;
        string father;
        public Dog(string name, string sex) 
        {
            this.name = name;
            this.sex = sex;
        }
        public string Mother(Dog Mother) 
        {
            mother = Mother.name;
            return mother;
        }
        public string Father(Dog Father)
        {
            father = Father.name;
            return father;
        }
        public string fathersName() 
        {
            if (father == null)
            {
                return "Unknown";
            }
            else 
            {
                return father;
            }
        }
        public bool HasSameMotherAs(Dog a) 
        {
            if(a.mother == mother) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
