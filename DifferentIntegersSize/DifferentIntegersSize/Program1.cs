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
            long n1;
            var n = Console.ReadLine();
            var canfit = long.TryParse(n, out n1);

            if(!canfit)
            {
                Console.WriteLine($"{n} can't fit in any type");
                return;
            }

       

            int a = 0;
            int z = 0;
            int z1 = 0;
            int z2 = 0;
            int z3=0;
            int z4 = 0;
          
           
                try
                {
                Convert.ToSByte(n1);
                z = 1;

                }
                catch
                {
                a++;
                }

            try
            {
                Convert.ToByte(n1);
                z1 = 1;
                
            }

            catch
            {
                a++;
            }

            try
            {
                Convert.ToInt16(n1);
                z2 = 1;
                
            }
            catch
            {
                a++;
            }

            try
            {
                Convert.ToUInt16(n1);
                z3 = 1;
            }
            catch
            {
                a++;
            }
            try
            {
                Convert.ToInt64(n1);
                z4 = 1;
            }
        

            catch
            {
                a++;
            }

                Console.WriteLine($"{n1} can fit in:");

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
                     if(n1>=int.MinValue&&n1<=int.MaxValue)
                    Console.WriteLine("* int");
                    if(n1>=0&&(n1 >= uint.MinValue && n1 <= uint.MaxValue))
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
               
            

           






        }
    }
}
