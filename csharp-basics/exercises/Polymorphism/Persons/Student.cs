using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Student : Person
    {
        private double gpa;

        public Student(double gpa) 
        {
            this.gpa = gpa;
        }

        public double _gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Student GPA = " + gpa);
        }
    }
}
