using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SavingsAccount
    {
        int _startingBalance;

        public SavingsAccount(int Start) 
        {
            _startingBalance = Start;
        }

        public int Withdawal (int a) 
        {
            return _startingBalance -= a;
        }

        public int Deposit(int a)
        {
            return _startingBalance += a;
        }

        public int Interest(int rate,int month) 
        {
            int dep = 0;
            int depsum = 0;
            int wid = 0;
            int widsum = 0;
            double inter = 0;

            for (int i = 1; i <= month; i++)
            {
                Console.WriteLine("Enter amount deposited for month: " + i + ": ");
                dep = int.Parse(Console.ReadLine());
                _startingBalance = Deposit(dep);
                depsum = depsum + dep;
                Console.WriteLine("Enter amount of withdrawn for month: " + i + ": ");
                wid = int.Parse(Console.ReadLine());
                _startingBalance = Withdawal(wid);
                widsum = widsum + wid;
            }

            inter = (_startingBalance*((1+rate)*month) - _startingBalance)/10;
            Console.WriteLine("Total deposit: $" + depsum);
            Console.WriteLine("Total withdrawn: $" + widsum);
            Console.WriteLine("Interest earned: $" + inter);
            Console.WriteLine("Ending balance: $" + (widsum+depsum+inter));
            return _startingBalance;
        }
    }
}
