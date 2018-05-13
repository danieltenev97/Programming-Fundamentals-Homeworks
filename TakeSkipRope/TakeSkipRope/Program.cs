using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
     

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           

            List<string> numbers = new List<string>();

            List<string> inputlist = new List<string>();
            
            for (int i = 0; i < input.Length; i++)
            {
                int a = (int)input[i];
                string c = input[i].ToString();
               
                if(a>=48&&a<=57)
                {
                    numbers.Add(c);
                }
                else
                {
                    inputlist.Add(c);
                }

            }
            //   Console.WriteLine(string.Join(" ",numbers));
           //    Console.WriteLine(string.Join("",inputlist)); //skipTest_String044170


            List<int> takelist = new List<int>();
            List<int> skiplist = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int digit = int.Parse(numbers[i]);
                if(i%2==0)
                {
                    takelist.Add(digit);
                        
                }
                else
                {
                    skiplist.Add(digit);
                }
            }
           
            var result= new StringBuilder();

            int skip = 0;
           // int take = 0;
            for (int i = 0; i < takelist.Count; i++)
            {
                result.Append(string.Concat(inputlist.Skip(skip).Take(takelist[i])));
                skip += skiplist[i]+takelist[i];

            }

            Console.WriteLine(result.ToString());
        }
    }
}
