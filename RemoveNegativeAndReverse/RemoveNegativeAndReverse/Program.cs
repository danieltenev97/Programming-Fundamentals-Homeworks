using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativeAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> number = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> number1 = new List<int>();


            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] > 0)
                {
                    number1.Add(number[i]);
                }
            }
            number1.Reverse();
            if (number1.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            foreach (var item in number1)
            {
                Console.Write(item + " ");
            }

        }
    }
}
