using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            long[] quantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            
          
        /*    int index = 0;
            string[] newarr0 = new string[names.Length];
            long[] newarr1 = new long[names.Length];
            decimal[] newarr2 = new decimal[names.Length]; */

            string input = Console.ReadLine();
            long[] newquantiy = new long[names.Length]; 
            if(quantity.Length<names.Length)
            {
               // int a = names.Length - quantity.Length;
                for (int i = 0; i <names.Length; i++)
                {
                    if(i<quantity.Length)
                    {
                        newquantiy[i] = quantity[i];
                    }
                    else
                    {
                        newquantiy[i] = 0;
                    }
                  
                }
            }
            else
            {
                newquantiy = quantity;

            }

            while(input!="done")
            {
                string[] newinput = input.Split(' ').ToArray();
                long quantities = long.Parse(newinput[1]);
                for (int i = 0; i < names.Length; i++)
                {
                    if(names[i]==newinput[0])
                    {
                       if(newquantiy[i]<quantities)
                        {
                            Console.WriteLine($"We do not have enough {names[i]}");
                        }
                       else
                        {
                            long used = newquantiy[i];
                            decimal price = long.Parse(newinput[1]) * prices[i];
                            newquantiy[i] = used-quantities;
                            Console.WriteLine($"{names[i]} x {newinput[1]} costs {price:F2}");
                        }

                     /*   newarr0[index] = names[i];
                        newarr1[index] = quantity[i];
                        newarr2[index] = prices[i];
                        index++; */
                    }
                }


                input = Console.ReadLine();
            }


       /*     for (int i = 0; i < newarr0.Length; i++)
            {
                if(newarr0[i]!=null)
                Console.WriteLine($"{newarr0[i]} costs: {newarr2[i]}; Available quantity: {newarr1[i]}");
            } */
        }
    }
}
