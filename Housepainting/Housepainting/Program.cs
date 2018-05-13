using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housepainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double prednastena = x * x - (1.2 * 2);
            double zadnastena = x * x;
            double strancihnisteni = (x * y - 1.5 * 1.5) * 2;
            double pokriv = (x * y) * 2 + ((x * h) / 2) * 2;

            double zelenaboq = (prednastena + zadnastena + strancihnisteni) / 3.4;
            double chervenaboq = pokriv / 4.3;

            Console.WriteLine($"{zelenaboq:F2}");
            Console.WriteLine($"{chervenaboq:F2}");

        }
    }
}
