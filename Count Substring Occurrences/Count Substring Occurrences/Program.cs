using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine().ToLower();

            string b = Console.ReadLine().ToLower();
            int counter = 0;
            int n = b.Length;
            int index = 0;
       //     int index1 = a.IndexOf(b);

            Console.WriteLine(index1);

           while(index!=a.Length-n+1)
            {
              string c=a.Substring(index, n);
                
                if(c==b)
                {
                    counter++;
                }
                

                index++;
            }


            Console.WriteLine(counter);

        }
    }
}
