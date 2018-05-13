using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRanege
{
    class Program
    {
        static List<int> FindPrimeIntegers(int start,int end)
        {
            
            int counter = 0;
            List<int> elements = new List<int>();
            for (int i = start; i <=end; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    if(i%j==0)
                    {
                        counter++;
                    }
                }
               
                if(counter==2)
                {
                    elements.Add(i);
                    
                }
                counter = 0;
            }

           

            return elements;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            List<int> elements = new List<int>();

            if(a>b)
            {
                Console.WriteLine("(empty list)");
                return;
            }
            
            elements=FindPrimeIntegers(a, b);
            int a1 = elements.Count;
            int counter = 0;
            foreach (var item in elements)
            {
                counter++;
                if (counter==a1)
                {
                    Console.Write($"{item} ");
                }
                else
                Console.Write($"{item}, ");

                
            }
         

        }
    }
}
