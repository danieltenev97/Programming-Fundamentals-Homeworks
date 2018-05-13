using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvenandOddnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            a = Math.Abs(a);
            int c = 1;
            int oddsum = 0;
            int evensum = 0;
           
            while(true)
            {
                if (a == 0) break;
                c = a % 10;
                if(c%2==0)
                {
                    evensum = evensum + c;
                }
                else
                {
                    oddsum = oddsum + c;
                }
                a = a / 10;
            }

            int result = evensum * oddsum;

            Console.WriteLine(result);

        }
    }
}
