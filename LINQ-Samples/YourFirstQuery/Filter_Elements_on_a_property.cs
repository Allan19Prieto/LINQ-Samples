using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Samples.YourFirstQuery
{
    internal class Filter_Elements_on_a_property
    {
        public static void Ejemplo()
        {
            
            List<Product> products = GetProductList();

            var soldOutProducts = from prod in products
                                  where prod.UnitsInStock == 0
                                  select prod;
            Console.WriteLine("Sold out products:");
            foreach ( var produt in soldOutProducts)
            {
                Console.WriteLine($"{produt.ProductName} is sold out!");
            }
        }

        public class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int UnitsInStock { get; set; }
        }

        public static List<Product> GetProductList()
        {
            return new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Chai", UnitsInStock = 10 },
                new Product { ProductID = 2, ProductName = "Chang", UnitsInStock = 0 },
                new Product { ProductID = 3, ProductName = "Aniseed Syrup", UnitsInStock = 20 },
                new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", UnitsInStock = 0 },
                new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", UnitsInStock = 0 },
                // agregar más productos aquí
            };
        }

    }
}
