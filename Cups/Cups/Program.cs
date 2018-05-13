using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cups
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbercups = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int workinghours = (workers * 8) * days;
            double numbercupsprice = numbercups * 4.20;
            double cupsmade = workinghours / 5;
            Math.Floor(cupsmade);

            double cuprice = cupsmade * 4.20;

            if(cupsmade>=numbercups)
            {
                double extramoney = cuprice - numbercupsprice;
                Console.WriteLine($"{extramoney:F2} extra money");
            }
            else
            {
                double lostmoney = numbercupsprice - cuprice;
                Console.WriteLine($"Losses: {lostmoney:F2} ");
            }


        }
    }
}
