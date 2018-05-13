using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankCapacity
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int sum = 0;

            if (n > 20) return;

            for (int i = 0; i <n; i++)
            {
                a = int.Parse(Console.ReadLine());
                
                sum = sum + a;

                if (sum < 0) return;
                if (sum>250)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum = sum - a;
                   //continue;
                }
                

            }

            Console.WriteLine(sum);

        }
    }
}
