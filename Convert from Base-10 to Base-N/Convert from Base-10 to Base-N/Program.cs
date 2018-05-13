using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Convert_from_Base_10_to_Base_N
{
    class Program
    {
        static void Main(string[] args)
        {
          
           var a = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            double baseNum = double.Parse(a[0]);

            if(baseNum<2||baseNum>10)
            {
                return;
            }
            string numsToConvert = a[1];

            double result = 0;
            int stepen = numsToConvert.Length - 1;
            int index = 0;

            while (stepen >= 0)
            {
                double big =double.Parse(numsToConvert.Substring(index,1));
              //  Console.WriteLine(big);
                double ad = Math.Pow(baseNum, stepen);
                var remainder = big *ad ; 
                result = remainder + result;
                stepen--;
                index++;
            }

            Console.WriteLine(result);


          
        }
    }
}
