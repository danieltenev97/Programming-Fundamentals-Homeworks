using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BevarageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energycontent = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double sper100 = (sugar / 100) * volume;
            double eper100 = (energycontent / 100) * volume;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{Math.Round(eper100, 2)}kcal, {Math.Round(sper100,2)}g sugars");

        }
    }
}
