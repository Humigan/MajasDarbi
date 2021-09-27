using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.exe12.Test
{
    public class ClassesAndObjects_exe12
    {
        private string _name;
        private double _money = 0;

        public double withdrawal(double i)
        {
            _money -= i;
            return i;
        }

        public double deposit(double i)
        {
           return _money += i;
        }

        public double balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double Transfer(ClassesAndObjects_exe12 from, ClassesAndObjects_exe12 to, double howMuch)
        {
           return to.deposit(from.withdrawal(howMuch));
        }
    }
}