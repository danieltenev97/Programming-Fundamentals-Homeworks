using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftfood = int.Parse(Console.ReadLine());
            double firstdeer = double.Parse(Console.ReadLine());
            double seconddeer = double.Parse(Console.ReadLine());
            double thirddeer = double.Parse(Console.ReadLine());

            double firstdeerfood = firstdeer * days;
            double secondeerfood = seconddeer * days;
            double thirddeerfood = thirddeer * days;

            double totalfood = firstdeerfood + secondeerfood + thirddeerfood;

            if(leftfood>totalfood)
            {
                double leftfood1 = leftfood - totalfood;
                Console.WriteLine($"{Math.Floor(leftfood1)} kilos of food left.");
            }

            else
            {
                double leftfood1 = totalfood-leftfood;
                Console.WriteLine($"{Math.Ceiling(leftfood1)} more kilos of food are needed.");
            }



        }
    }
}
