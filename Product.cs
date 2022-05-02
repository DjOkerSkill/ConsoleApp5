using System;


namespace ConsoleApp5
{
    public class Product
    {
         public string Name { get; private set; }
         public string Brand { get; private set; }
         public double Price { get; private set; }

        public Product() { }

        public Product(string Name, string Brand, double Price) 
        { 
            this.Name = Name;
            this.Brand = Brand;
            this.Price = Price;
        }
    }
}
