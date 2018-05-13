using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp84
{
    class Program
    {
        static void Main(string[] args)
        {
            string person = Console.ReadLine();
            string drink = "";

            if(person.Equals("Athlete"))
            {
                drink = "Water";

            }

            else if(person.Equals("Businessman") || person.Equals("Businesswoman"))
            {
                drink = "Coffee";
            }
            else if (person.Equals("SoftUni Student"))
            {
                drink = "Beer";

            }

            else
            {
                drink = "Tea";
            }

            Console.WriteLine(drink);
        }
    }
}
