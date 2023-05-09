using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Samples.YourFirstQuery
{
    public class LINQ_query_structure
    {
        public static void Ejemplo()
        {
            // LINQ query structure
            // This sample uses where to find all elements of an array less than 5. 
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums = from num in numbers
                          where num < 5
                          select num;

            Console.WriteLine("Number < 5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }
        }
    }
}
