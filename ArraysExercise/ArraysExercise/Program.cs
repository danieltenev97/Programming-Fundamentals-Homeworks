using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int daynumber = int.Parse(Console.ReadLine());

            string[] days = {"Monday","Tuesday","Wednesday","Thursday", "Friday","Saturday","Sunday" };

            if (daynumber < 1 || daynumber > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }

            string days1 = days[daynumber - 1];

            Console.WriteLine(days1);

   


        }
    }
}
