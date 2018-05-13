using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysExercise11
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int min = arr.Min();
            int max = arr.Max();
            int sum = arr.Sum();
            double average = arr.Average();

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }

}
