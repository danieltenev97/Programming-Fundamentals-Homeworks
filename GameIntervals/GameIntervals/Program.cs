using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int turn = int.Parse(Console.ReadLine());
            int numbers = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double e = 0;
            double result = 0;
            double invalidNumber = 0;
            for (int i = 1; i <=turn; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                if(numbers<0||numbers>50)
                {
                    invalidNumber++;
                    result = result / 2;
                }
                if(numbers<10&&numbers>=0)
                {
                    a++;
                    result = result + numbers * 0.20;
                }

                else if(numbers>=10&&numbers<20)
                {
                    b++;
                    result = result + numbers * 0.30;

                }
                else if (numbers >= 20 && numbers < 30)
                {
                    c++;
                    result = result + numbers * 0.40;

                }
                else if (numbers >= 30 && numbers < 40)
                {
                    d++;
                    result = result + 50;

                }
                else if (numbers >= 40 && numbers <=50)
                {
                    e++;
                    result = result + 100;

                }

            }

            a = (a / turn) * 100;
            b = ( b/ turn) * 100;
            c = (c / turn) * 100;
            d = (d / turn) * 100;
            e = (e / turn) * 100;
            invalidNumber = (invalidNumber / turn) * 100;

            Console.WriteLine($"{result:F2}");
            Console.WriteLine($"From 0 to 9: {a:F2}%");
            Console.WriteLine($"From 10 to 19: {b:F2}%");
            Console.WriteLine($"From 20 to 29: {c:F2}%");
            Console.WriteLine($"From 30 to 39: {d:F2}%");
            Console.WriteLine($"From 40 to 50: {e:F2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumber:F2}%");

        }
    }
}
