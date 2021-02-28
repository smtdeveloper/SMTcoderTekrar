using System;
using System.Collections.Generic;
using System.Linq;

namespace LınqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                 new Category{ CategoryId = 1, CategoryName = "Laptop"},
                 new Category{ CategoryId = 2, CategoryName = "Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ ProductId = 1 , CategoryId = 1, ProductName = "Monster Laptop" , QuantityPerUnit = "32 GB" , UnitPrice = 9000, UnitInStok = 3 },
                new Product{ ProductId = 2 , CategoryId = 2, ProductName = "Samsung S8 Telefon" , QuantityPerUnit = "16 GB" , UnitPrice = 3000, UnitInStok = 8 },
                new Product{ ProductId = 3 , CategoryId = 2, ProductName = "Samsung S4 Telefon" , QuantityPerUnit = "8 GB" , UnitPrice = 1000, UnitInStok = 5 },
                new Product{ ProductId = 4 , CategoryId = 1, ProductName = "HP Laptop" , QuantityPerUnit = " 8 GB" , UnitPrice = 5000, UnitInStok = 9 },
            };

            // && ve
            Console.WriteLine("Algoritmatik---------------- ");
            foreach (var item in products)
            {
                if (item.UnitPrice >= 5000  && item.UnitInStok> 3)  
                {
                    Console.WriteLine(item.ProductName);
                }
              
            }

            Console.WriteLine("LINQ İLE----------");

            var result = products.Where(p => p.UnitPrice >= 5000 && p.UnitInStok > 3);

            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

            GetProducts(products);
        }

        // Algoritmatik 
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filtereProducts = new List<Product>();

            foreach (var item in products)
            {
                if (item.UnitPrice > 5000 && item.UnitInStok > 3)
                {
                    filtereProducts.Add(item);
                }
               
            }
            return filtereProducts;
        }

        // Linq ile
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return  products.Where(p => p.UnitPrice >= 5000 && p.UnitInStok > 3).ToList();  // return dönüs

        }
        

    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string   QuantityPerUnit  { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStok { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
