﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Boundaries
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            string type = Console.ReadLine().ToLower();

            switch (type)
                {
                case "sbyte":
                    Console.WriteLine(sbyte.MaxValue);
                    Console.WriteLine(sbyte.MinValue);
                    
                   break;
                case "byte":
                    Console.WriteLine(byte.MaxValue);
                    Console.WriteLine(byte.MinValue);

                    break;

                case "int":
                    Console.WriteLine(int.MaxValue);
                    Console.WriteLine(int.MinValue);

                    break;
                case "uint":
                    Console.WriteLine(uint.MaxValue);
                    Console.WriteLine(uint.MinValue);

                    break;
                case "long":
                    Console.WriteLine(long.MaxValue);
                    Console.WriteLine(long.MinValue);

                    break;
            }
             */

            decimal a; ;
            try
            {
                a = long.Parse(Console.ReadLine());

                Console.WriteLine("integer");
            }

            catch
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
