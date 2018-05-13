using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            double average = numbers.Average();

            var numbersreamin = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbersreamin.Add(numbers[i]);
                }
            }

            for (int i = 0; i <numbersreamin.Count ; i++)
            {
                if(numbersreamin[i]>Math.Ceiling(average))
                {
                    numbersreamin[i]++;
                }
                else if(numbersreamin[i] < Math.Ceiling(average))
                {
                    numbersreamin[i]--;
                }

            }

            Console.WriteLine(string.Join(" ",numbersreamin));

           
          
        }
    }
}
