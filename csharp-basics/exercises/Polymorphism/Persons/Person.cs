using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string address;
        private int id;

        public Person() 
        {   }

        public Person(string firstName, string lastName, string address,int id) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.id = id;
        }

        public string _firstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string _lastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string _address
        {
            get { return address; }
            set { address = value; }
        }

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual void display() 
        {
            Console.WriteLine("firstName " + firstName);
            Console.WriteLine("lastName " + lastName);
            Console.WriteLine("address " + address);
            Console.WriteLine("id " + id);
        }
    }
}
