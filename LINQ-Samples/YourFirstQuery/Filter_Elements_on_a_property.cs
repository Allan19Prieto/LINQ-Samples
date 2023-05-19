using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Samples.Data;

namespace LINQ_Samples.YourFirstQuery
{
    internal class Filter_Elements_on_a_property
    {
        public static void Ejemplo()
        {
            
            List<Product> products = Product.GetProductList();

            var soldOutProducts = from prod in products
                                  where prod.UnitsInStock == 0
                                  select prod;
            Console.WriteLine("Sold out products:");
            foreach ( var produt in soldOutProducts)
            {
                Console.WriteLine($"{produt.ProductName} is sold out!");
            }
        }

    }
}
