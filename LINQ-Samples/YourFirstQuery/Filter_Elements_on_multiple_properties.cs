using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Samples.Data;

namespace LINQ_Samples.YourFirstQuery
{
    public class Filter_Elements_on_multiple_properties
    {
        public static void Ejemplo()
        {
            List<Product> products = Product.GetProductList();

            var expensiveInStockProducts = from prod in products
                                           where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00
                                           select prod;
            Console.WriteLine("In-Stock products that cost name than 3.00:");
            foreach (var product in expensiveInStockProducts)
            {
                Console.WriteLine($"{product.ProductName} is in stock and costs more than 3.00.");
            }
        }
    }
}
