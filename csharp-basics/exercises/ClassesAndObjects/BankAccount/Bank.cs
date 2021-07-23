using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Bank
    {
        string name;
        double balance;
        public Bank(string name, double balance) 
        {
            this.name = name;
            this.balance = balance;
        }
        public string ShowUserNameAndBalance() 
        {
            string a;
            if (balance>0)
            {
                a = name + ", $" + balance;
                Console.WriteLine(name + ", $" + balance);
                return a;
            }
            else
            {
                a = name + ", -$" + (-1*balance);
                Console.WriteLine(a);
                return a;
            }
            
        }
    }
}
