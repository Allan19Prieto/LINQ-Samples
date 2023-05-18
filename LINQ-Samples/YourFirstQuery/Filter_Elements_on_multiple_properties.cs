using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Samples.YourFirstQuery
{
    public class Filter_Elements_on_multiple_properties
    {
        public static void Ejemplo()
        {
            List<Product> products = new List<Product>();

            var expensiveInStockProducts = from prod in products
                                           where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00
                                           select prod;
            Console.WriteLine("In-Stock products that cost name than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                Console.WriteLine($"{product.ProductName} is in stock and costs more than 3.00.");
            }
        }

        public class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int UnitsInStock { get; set; }
            public double UnitPrice { get; set; }
        }

        public static List<Product> GetProductList()
        {
            return new List<Product>
            {
                new Product { ProductID = 1, ProductName = "Chai", UnitsInStock = 10, UnitPrice = 4.00 },
                new Product { ProductID = 2, ProductName = "Chang", UnitsInStock = 0, UnitPrice = 5.00 },
                new Product { ProductID = 3, ProductName = "Aniseed Syrup", UnitsInStock = 20, UnitPrice = 3.00 },
                new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", UnitsInStock = 40 , UnitPrice = 7.05 },
                new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", UnitsInStock = 0, UnitPrice = 1.50 },
                // agregar más productos aquí
            };
        }
    }
}
