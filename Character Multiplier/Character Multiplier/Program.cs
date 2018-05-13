using System;
using System.Linq;
using System.Collections.Generic;


namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            string a = input[0];
            string b = input[1];

            int length1 = a.Length;
            int length2 = b.Length;

            int multiply=0;
            int sum = 0;

            for (int i = 0; i <Math.Min(length1,length2); i++)
            {
                multiply = a[i] * b[i];
                sum = sum + multiply;

            }

            int max = Math.Max(length1, length2);
            int min= Math.Min(length1, length2);

            if(max>min)
            {
                for (int i = min; i <max; i++)
                {
                    if (max == length1)
                    {
                        sum = sum + a[i];
                        
                    }
                    else
                    {
                        sum = sum + b[i];
                        

                    }

                    
                     
                }

            }


            Console.WriteLine(sum);
        }
    }
}
