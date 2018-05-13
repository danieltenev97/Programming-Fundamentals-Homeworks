using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1Task
{
    class Program
    {
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("-- -- -- -- -- -- -- -- -- -- -- -- -- -- --");
        }

     
        static void Main(string[] args)
        {
            PrintHeader();
            PrintMId();
            PrintEnd();
        }

        static void PrintMId()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintEnd()
        {
            String a = string.Format("\u00A9");
            Console.WriteLine("-- -- -- -- -- -- -- -- -- -- -- -- -- -- --");
            Console.WriteLine($"{a} SoftUni");

        }
    }
}
