using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonuspoints
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double bonus = 0;
            if(a<=100)
            {
                bonus = 5;
            }
            else if(a>100&&a<=1000)
            {
                bonus = a * 0.2;
            }

            else
            {
                bonus = a *0.1;
            }

            if(a%2==0)
            {
                bonus++;
            }

            if(a%10==5)
            {
                bonus = bonus + 2;
            }
            double totalpoints = a + bonus;

            Console.WriteLine("{0}",Math.Round(bonus,1));
            Console.WriteLine("{0}",Math.Round(totalpoints,1));
        }
    }
}
