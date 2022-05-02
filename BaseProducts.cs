using System;

namespace ConsoleApp5
{
    public class BaseProducts
    {
        Product[] products = new Product[0];
        public void AddProduct(Product product) 
        { 
            Array.Resize(ref products, products.Length+1);
            products[products.Length-1] = product;
            Order.Size = products.Length;
        }
        public Product GetProduct(int index) 
        { 
            return products[index];
        }
    }
}
