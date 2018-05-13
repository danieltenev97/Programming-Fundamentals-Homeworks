using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int numberoffans = int.Parse(Console.ReadLine());
            double Asektorfans = 0;
            double Bsektorfans = 0;
            double Vsektorfans = 0;
            double Gsektorfans = 0;
            int i = 0;



            while(i<=numberoffans)
            {
                string sektor = Console.ReadLine();

                if(sektor.Equals("A"))
                {
                    Asektorfans++;
                }

                else if (sektor.Equals("B"))
                {
                    Bsektorfans++;
                }
                else if (sektor.Equals("V"))
                {
                    Vsektorfans++;
                }
                else if (sektor.Equals("G"))
                {
                    Gsektorfans++;
                }
                i++;
            }

            Asektorfans = (Asektorfans / numberoffans)*100;
            Bsektorfans = (Bsektorfans / numberoffans)*100;
            Vsektorfans = (Vsektorfans / numberoffans)*100;
            Gsektorfans = (Gsektorfans / numberoffans)*100;

            double totalfans = ((double)numberoffans / (double)capacity) * 100; 

            Console.WriteLine($"{Asektorfans:F2}%");
            Console.WriteLine($"{Bsektorfans:F2}%");
            Console.WriteLine($"{Vsektorfans:F2}%");
            Console.WriteLine($"{Gsektorfans:F2}%");
            Console.WriteLine($"{totalfans:F2}%");

        }
    }
}
