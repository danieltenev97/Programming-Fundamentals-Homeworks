using System;
using System.Collections.Generic;
using System.Linq;

namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;
            while(true)
            {
                if(numbers.Count==0) { break; }

                int index = int.Parse(Console.ReadLine());

                int removeElement = 0;

                if(index<0)
                {
                    index = 0;
                    removeElement = numbers[index];
                    numbers[index] = numbers[numbers.Count - 1];
                  
                }
                else if(index>numbers.Count-1)
                {
                    index = numbers.Count - 1;
                    removeElement = numbers[numbers.Count - 1];
                    numbers[index] = numbers[0];
                    
                }
                else
                {
                    removeElement = numbers[index];
                    numbers.RemoveAt(index);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    int element = numbers[i];
                    if(element>removeElement)
                    {
                        element = element - removeElement;
                    }
                    else
                    {
                        element = element + removeElement;
                    }

                    numbers[i] = element;
                }

                sum = sum + removeElement;
            }

            Console.WriteLine(sum);
        }
    }
}
