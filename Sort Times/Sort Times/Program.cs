using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            List<DateTime> list = new List<DateTime>();
            for (int i = 0; i < input.Count; i++)
            {
                var time = DateTime.ParseExact(input[i], "HH:mm", CultureInfo.InvariantCulture);
                

                list.Add(time);
            }
            list.Sort();


            for (int i = 0; i < list.Count-1; i++)
            {
                Console.Write(list[i].ToString("HH:mm")+", ");
            }

            Console.Write(list[list.Count-1].ToString("HH:mm"));
            Console.WriteLine();
            

            

        }
    } 
}
