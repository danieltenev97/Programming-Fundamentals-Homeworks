using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenhours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workdays = int.Parse(Console.ReadLine());

            int dayworkinghours = (workers * 8)*workdays;

            int lefthours = Math.Max(givenhours, dayworkinghours) - Math.Min(givenhours, dayworkinghours);

            if(givenhours<=dayworkinghours)
            {
                Console.WriteLine($"{lefthours} hours left");
            }
            else
            {
                int neystoyka = lefthours * workdays;
                Console.WriteLine($"{lefthours} overtime");
                Console.WriteLine($"Penalties: {neystoyka}");
            }
        }
    }
}
