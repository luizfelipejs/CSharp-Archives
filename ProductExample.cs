using System;
using System.Collections.Generic;

namespace AppsCsharp
{
    class Program
    {
        class Product
        {
            public Product ()
            {
                Name = "Undefined";
                Price = 0;
            }

            public Product (string name, int price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; }
            public int Price { get; }
        }
        static void Main()
        {
            List<Product> products = new List<Product>();
            
            for (int count = 0; count < 100; count++)
            {
                Product productCreated = new Product($"{count}", count);
                products.Add(productCreated); 
            }

            foreach (Product productItem in products) 
            {
                Console.WriteLine($"Nome = {productItem.Name}, Preço =  {productItem.Price}");
            }
        }
    }
}
