using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

           
            int a = 0;
            int z = 0;
            int z1 = 0;
            int z2 = 0;
            int z3=0;
            int z4 = 0;
            int z5 = 0;
           
                try
                {
                Convert.ToSByte(n);
                z = 1;

                }
                catch
                {
                a++;
                }

            try
            {
                Convert.ToByte(n);
                z1 = 1;
                
            }

            catch
            {
                a++;
            }

            try
            {
                Convert.ToInt16(n);
                z2 = 1;
                
            }
            catch
            {
                a++;
            }

            try
            {
                Convert.ToUInt16(n);
                z3 = 1;
            }
            catch
            {
                a++;
            }
            try
            {
                Convert.ToInt64(n);
                z4 = 1;
            }
        

            catch
            {
                a++;
            }

            if(a!=5)
            {
                Console.WriteLine($"{n} can fit in:");

                if(z==1)
                {
                    Console.WriteLine("* sbyte");
                }
                if(z1==1)
                {
                    Console.WriteLine("* byte");
                }
                if (z2 == 1)
                {
                    Console.WriteLine("* short");
                }
                if (z3 == 1)
                {
                    Console.WriteLine("* ushort");
                }
                if (z4 == 1)
                {
                    Console.WriteLine("* int");
                    if(n>=0)
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
               
            }

           else
            {
                Console.WriteLine($"{n} can't fit in any type");
               // return;
            }






        }
    }
}
