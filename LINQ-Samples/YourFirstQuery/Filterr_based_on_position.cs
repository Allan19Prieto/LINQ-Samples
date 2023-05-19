using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Samples.YourFirstQuery
{
    public class Filterr_based_on_position
    {
        public static void Ejemplo()
        {
            string[] digits = { "Zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigits = digits.Where((digits, index) => digits.Length < index);

            Console.WriteLine("Short digits");
            foreach ( var d in shortDigits)
            {
                Console.WriteLine($"The word {d} is shorter than its value");
            }
        }
    }
}
