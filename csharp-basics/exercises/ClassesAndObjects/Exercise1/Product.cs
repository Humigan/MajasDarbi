using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        string name;
        double price;
        int amount;
       public Product(string name, double priceAtStart, int amountAtStart) 
        {
            this.name = name;
            price = priceAtStart;
            amount = amountAtStart;
        }
        public void PrintProduct() 
        {
            Console.WriteLine(name + ", " + "price " + price +" EUR "+ ", " + "amount " + amount);
        }

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
