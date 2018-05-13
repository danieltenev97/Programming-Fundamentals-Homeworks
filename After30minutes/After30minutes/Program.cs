﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After30minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;
            if (minutes >= 60)
            {
                hours++;
                minutes = minutes - 60;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");

           
        }
    }
}