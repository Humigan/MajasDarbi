using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects.exe1.Test
{
    public class ClassesAndObjects_exe1
    {
        string name;
        double price;
        int amount;

        public int ChangeQuantity(int quan)
        {
            amount = quan;
            return amount;
        }

        public int ChangePrice(int price)
        {
            this.price = price;
            return price;
        }
    }
}
