using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Samples.Data
{

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public double UnitPrice { get; set; }

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
