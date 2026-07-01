using System;
using System.Collections.Generic;

namespace ProductCatalog
{
    class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>()
            {
                new Product("Laptop",45000,Category.Electronics),
                new Product("Mouse",800,Category.Electronics),
                new Product("Rice",1200,Category.Grocery),
                new Product("Shirt",1500,Category.Clothing),
                new Product("Jeans",2500,Category.Clothing)
            };

            Console.WriteLine("PRODUCT CATALOG\n");

            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine(category);

                foreach (Product product in products)
                {
                    if (product.Category == category)
                    {
                        Console.WriteLine($"   {product.Name} - {product.Price}");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}