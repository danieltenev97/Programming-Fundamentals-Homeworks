using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i <n; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            int sum = numbers.Sum();
            int max = numbers.Max();
            int min = numbers.Min();
            double average = numbers.Average();

            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
