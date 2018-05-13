using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = years * 365.2422;
            
          int hours = (int)days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;

            decimal miliseconds = seconds * 1000;
            decimal microsecond=miliseconds*1000;
            decimal nanoseconds = miliseconds * 1000000;

            Console.WriteLine($"{centuries} centuries = {years} years = {(int)days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microsecond} microseconds = {nanoseconds} nanoseconds");
              
            

        }
    }
}
