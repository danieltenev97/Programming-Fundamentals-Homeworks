using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigit
{
    class Program
    {
        static long LastDigit(long a)
        {
            long lastDigit = a % 10;

            switch(lastDigit)
            {
                case 1: return 1;
                    
                case 2:
                 return 2;

                    
                case 3:
                    return 3;
                case 4:
                    return 4;
                case 5:
                    return 5;
                case 6:
                    return 6;
                case 7:
                    return 7;
                case 8:
                    return 8; ;
                case 9:
                    return 9;

                default:
                    return 0;
                    
            }
        }

        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long result=LastDigit(a);

            switch(result)
            { 
              case 1: Console.WriteLine("one");
            break;
                case 2:
                    Console.WriteLine("two");
            break;
                case 3:
                    Console.WriteLine("three");
            break;
                case 4:
                    Console.WriteLine("four");
            break;
                case 5:
                    Console.WriteLine("five");
            break;
                case 6:
                    Console.WriteLine("six");
            break;
                case 7:
                    Console.WriteLine("seven");
            break;
                case 8:
                    Console.WriteLine("eight");
            break;
                case 9:
                    Console.WriteLine("nine");
            break;

            default: Console.WriteLine("zero");
            break;
        }

    }
    }
}
