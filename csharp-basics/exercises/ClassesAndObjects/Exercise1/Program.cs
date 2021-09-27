using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
          var Mouse = new Product("Logitech mouse", 70.00, 14);
          Mouse.PrintProduct();
          var Phone = new Product("iPhone 5s", 999.99, 3);
          Phone.PrintProduct();
          var Epson = new Product("Epson EB-U05", 440.46, 1);
          Epson.PrintProduct();
          Mouse.ChangePrice(55);
          Mouse.PrintProduct();
          Phone.ChangeQuantity(7);
          Phone.PrintProduct();
        }
    }
}
