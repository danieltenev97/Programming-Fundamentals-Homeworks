using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grozderakiq
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double brak = double.Parse(Console.ReadLine());

            double totalarea = area * b - brak;

            double rakiq = totalarea * 0.45;
            double grozde = totalarea * 0.55;

            double rakiqprice = (rakiq / 7.50) * 9.80;
            double grozdeprice = grozde * 1.50;

            Console.WriteLine($"{rakiqprice:F2}");
            Console.WriteLine($"{grozdeprice:F2}");

        }
    }
}
