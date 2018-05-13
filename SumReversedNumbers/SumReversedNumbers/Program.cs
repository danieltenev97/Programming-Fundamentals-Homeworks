using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
          List<string> numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
       
            int number = 0;
            int result = 0;
            string currentnumber;
            
         
            for (int i = 0; i < numbers.Count; i++)
            {
                string reversed = "";
                currentnumber = numbers[i];
                for (int j = currentnumber.Length - 1; j >= 0; j--)
                {
                    reversed += currentnumber[j];
                }

                number = int.Parse(reversed);

                result += number;

            }

           
            
            

            Console.WriteLine(result);
          
           
        }

    }
}
