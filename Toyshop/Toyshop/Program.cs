using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toyshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzlesQuantity = int.Parse(Console.ReadLine());
            int dollsQuantity = int.Parse(Console.ReadLine());
            int teddybearsQuantity = int.Parse(Console.ReadLine());
            int minionsQuantity = int.Parse(Console.ReadLine());
            int tracksQuantity = int.Parse(Console.ReadLine());
            

            int totalquantity = puzzlesQuantity + dollsQuantity + teddybearsQuantity + minionsQuantity + tracksQuantity;
            double puzzleprice = puzzlesQuantity * 2.60;
            double dollprice = dollsQuantity * 3;
            double teddybearsprice = teddybearsQuantity * 4.10;
            double minionsprice = minionsQuantity * 8.20;
            double tracksprice = tracksQuantity * 2;

            double totalprice = puzzleprice + dollprice + teddybearsprice + minionsprice + tracksprice;

            if(totalquantity>=50)
            {
                totalprice = totalprice * 0.75;
            }

            totalprice = totalprice * 0.9;

            if(totalprice>=holidayPrice)
            {
              double   moneyleft = totalprice - holidayPrice;
                Console.WriteLine($"Yes! {moneyleft:F2} lv left.");
            }
            else
            {
                double moneyneeded = holidayPrice - totalprice;
                Console.WriteLine($"Not enough money! {moneyneeded:F2} lv needed.");
            }
        }

    }
}
