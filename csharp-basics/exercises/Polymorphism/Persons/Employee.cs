using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Employee : Person
    {
        private string jobTitle;

        public Employee(string jobTitle)
        {
            this.jobTitle = jobTitle;
        }

        public string _jobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Job Title = " + jobTitle);
        }
    }
}
