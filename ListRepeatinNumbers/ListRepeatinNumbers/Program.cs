using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRepeatinNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            int counter = 1;
            numbers.Sort();

            numbers.Add(122);
            int first = numbers[0];
            
         
            for (int i=1;i<numbers.Count;i++)
            {
                
                if(first==numbers[i])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{first} -> {counter}");
                    counter = 1;
                    first = numbers[i];

                }
               }

          //  Console.WriteLine($"{first} -> {counter}");

        }
    }
}
