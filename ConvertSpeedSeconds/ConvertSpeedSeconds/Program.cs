using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float miles =(float) distance / 1609;

            if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60;
            }

            if (seconds >= 60)
            {
                minutes++;
                seconds = seconds - 60;
            }
            int hourforseconds = hours * 3600;
            int minutesforseconds = minutes * 60;

            int timeinseconds = seconds + minutesforseconds + hourforseconds;

            float speedmeterinseconds = (float)distance / (float)timeinseconds;

            float kilometer = (float)distance / 1000;



            float kilometerperhour = kilometer / ((float)timeinseconds / 3600);
            

            float mileperhour = miles / ((float)timeinseconds / 3600);




            Console.WriteLine(speedmeterinseconds);
            Console.WriteLine(kilometerperhour);
            Console.WriteLine(mileperhour);








        }
    }
}
