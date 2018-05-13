using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alkoholmarket
{
    class Program
    {
        static void Main(string[] args)
        {

            double whiskyprice = double.Parse(Console.ReadLine());
            double biraquantity = double.Parse(Console.ReadLine());
            double vinoquantity = double.Parse(Console.ReadLine());
            double rakiqquantity = double.Parse(Console.ReadLine());
            double whiskyquantity = double.Parse(Console.ReadLine());

            double rakiqprice = whiskyprice / 2;
            double vinoprice = rakiqprice - rakiqprice * 0.4;
            double biraprice = rakiqprice - rakiqprice * 0.8;

            double totalprice = (whiskyquantity * whiskyprice) + (rakiqquantity * rakiqprice) + (biraquantity * biraprice) + (vinoprice * vinoquantity);

            Console.WriteLine($"{ totalprice:F2}",Math.Round(totalprice,2));
        }
    }
}
