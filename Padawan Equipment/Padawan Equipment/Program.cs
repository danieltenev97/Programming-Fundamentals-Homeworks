using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountofmoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceoflightsabers = double.Parse(Console.ReadLine());
            double priceofrobes = double.Parse(Console.ReadLine());
            double priceofbelts = double.Parse(Console.ReadLine());

            
            double robes = students * priceofrobes;

            double lightsaberstudents = students + students * 0.10;

            lightsaberstudents = Math.Ceiling(lightsaberstudents);
            double lightsaberprice = lightsaberstudents * priceoflightsabers;
            int freebelts = students / 6;

            double totalbelts = students - freebelts;
            double totalbeltsprice = totalbelts * priceofbelts;

            double totalmoney = robes + totalbeltsprice + lightsaberprice;

            if(amountofmoney>=totalmoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalmoney:F2}lv.");
            }

            else
            {
                double moneyneeded = totalmoney - amountofmoney;
                Console.WriteLine($"Ivan Cho will need {moneyneeded:F2}lv more.");

            }




        }
    }
}
