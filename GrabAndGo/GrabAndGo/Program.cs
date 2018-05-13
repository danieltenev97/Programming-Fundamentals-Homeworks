using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int containingnumber = int.Parse(Console.ReadLine());

            int index = 0;
            int max = index;
            int sum = 0;
            bool isContained = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(containingnumber==numbers[i])
                {
                    index = i;
                    if(index>max)
                    {
                        max = index;
                    }
                    isContained = true;
                }

            }

            for (int i = 0; i <index; i++)
            {
                sum = sum + numbers[i];
            }

            if(isContained==false)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }                    

        }
    }
}
