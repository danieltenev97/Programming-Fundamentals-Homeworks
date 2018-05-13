using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int lesson = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            int counter = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            double priceforonelesson = budget / lesson;
            for (int i = 1; i <= lesson; i++)
            {
                string lector = Console.ReadLine();

                if (lector.Equals("Jelev"))
                {
                    counter++;
                }
                else if (lector.Equals("RoYaL"))
                {
                    counter1++;
                }
                else if (lector.Equals("Roli"))
                {
                    counter2++;

                }

                else if (lector.Equals("Trofon"))
                {
                    counter3++;

                }
                else if (lector.Equals("Sino"))
                {
                    counter4++;

                }
                else
                {
                    counter5++;
                }
            }
                Console.WriteLine($"Jelev salary: {counter*priceforonelesson:F2} lv");
                Console.WriteLine($"RoYaL salary: {counter1 * priceforonelesson:F2} lv");
                Console.WriteLine($"Roli salary: {counter2 * priceforonelesson:F2} lv");
                Console.WriteLine($"Trofon salary: {counter3 * priceforonelesson:F2} lv");
                Console.WriteLine($"Sino salary: {counter4 * priceforonelesson:F2} lv");
                Console.WriteLine($"Others salary: {counter5 * priceforonelesson:F2} lv ");

            

        }
    }
}
