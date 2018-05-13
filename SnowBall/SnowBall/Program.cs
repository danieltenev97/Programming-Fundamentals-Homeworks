using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace SnowBall
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int max1 = 0;
            int max2 = 0;
            BigInteger  snowballValue = 0;
            BigInteger maxsnowballValue = 0;

         //   int total = n * 3;
            int i = 0;
            while(i<n)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

               decimal fsnowballValue =(decimal)(snowballSnow / snowballTime);
                fsnowballValue = Math.Round(fsnowballValue);
               

               snowballValue =(int)Math.Pow((double)fsnowballValue, snowballQuality);

                if(snowballValue>=maxsnowballValue)
                {
                    maxsnowballValue = snowballValue;
                    max = snowballSnow;
                    max1 = snowballTime;
                    max2 = snowballQuality;

                }

                i++;

            }

            Console.WriteLine($"{max} : {max1} = {maxsnowballValue} ({max2})");
        }
    }
}
