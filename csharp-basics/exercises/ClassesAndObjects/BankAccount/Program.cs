using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tom = new Bank("Tom", 15.45);
            var Essie = new Bank("Essie", -33.70);
            Tom.ShowUserNameAndBalance();
            Essie.ShowUserNameAndBalance();
        }
    }
}
