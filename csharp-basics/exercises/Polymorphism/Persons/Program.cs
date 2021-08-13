using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var ppl = new Person();
            ppl._firstName = "Stas";
            ppl._lastName = "Boreckis";
            ppl._address = "Nicgales 40";
            ppl._id = 1115;
            ppl.display();

            var stud = new Student(20.5);
            stud._firstName = "Andrejs";
            stud._lastName = "Akels";
            stud._address = "Saharova 10";
            stud._id = 999;
            stud._gpa = 35.8;
            stud.display();

            var emp = new Employee("Taxi");
            emp._firstName = "Nikita";
            emp._lastName = "Tumens";
            emp._address = "Ilukstes 28";
            emp._id = 23;
            emp._jobTitle = "Teacher";
            emp.display();
        }
    }
}