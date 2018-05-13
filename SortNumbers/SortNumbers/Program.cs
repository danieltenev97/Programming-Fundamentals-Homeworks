using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            numbers.Sort();

            for (int i = 0; i < numbers.Count-1; i++)
            {
                Console.Write($"{numbers[i]}<=");
            }

            Console.WriteLine(numbers[numbers.Count-1]);

        }
    }
}
