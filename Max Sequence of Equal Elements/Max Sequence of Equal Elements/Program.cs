using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int counter = 1;
            int maxcounter = 1;
            
           int maxindex = 0;
           int index = 0;


            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    if (counter == 1) index = i;
                    counter++;
                }
                else
                {
                    counter = 1;

                }        

                if (counter > maxcounter)
                {
                    maxcounter = counter;
                    maxindex = index; 
                }
               
            }

            for (int i = maxindex; i <maxcounter+maxindex ; i++)
            {
                Console.Write(numbers[i] +" ");
            } 
        }
    }
}
