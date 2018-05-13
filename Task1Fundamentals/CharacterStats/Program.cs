using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int amax = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int bmax = int.Parse(Console.ReadLine());

            int c = amax - a;
            int d = bmax - b;
            int v = amax + 2;
            int z = bmax + 2;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: {0}{1}{2}",new string('|',a+1),new string('.',c),new string('|',v-c-(a+1)));
            Console.WriteLine("Energy: {0}{1}{2}", new string('|', b + 1), new string('.',d), new string('|', z - d - (b + 1)));


        }
    }
}
