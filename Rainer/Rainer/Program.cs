using System;
using System.Collections.Generic;
using System.Linq;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int index = numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
            int i = 0;
            List<int> savednumbers = new List<int>();
            foreach (var item in numbers)
            {
                savednumbers.Add(item);
            }
            bool isWet = false;
            while(true)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if(numbers[j]==0)
                    {
                        numbers[j] = savednumbers[j];
                    }
                    numbers[j]--;
                }
                if (numbers[index] == 0) { break; }
                index = int.Parse(Console.ReadLine());

               

             i++;
            }

            Console.WriteLine(string.Join(" ",numbers));
            Console.WriteLine(i);
        }
    }
}
