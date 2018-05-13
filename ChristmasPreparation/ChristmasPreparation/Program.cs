using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPaper = int.Parse(Console.ReadLine());
            int numberrolkiplat = int.Parse(Console.ReadLine());
            double leterglue = double.Parse(Console.ReadLine());
            int percentagediscount = int.Parse(Console.ReadLine());

            double paperprice = numberPaper * 5.80;
            double rolkaprice = numberrolkiplat * 7.20;
            double glueprice = leterglue * 1.20;

            double totalprice = paperprice + rolkaprice + glueprice;

           

            double discountprice = totalprice - (totalprice *((double)percentagediscount/100));
            
            Console.WriteLine($"{discountprice:F3}");

        }
    }
}
