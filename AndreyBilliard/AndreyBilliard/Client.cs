using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyBilliard
{
    class Client
    {

        public string name { get; set; }
        public Dictionary<string, int> productquantity = new Dictionary<string, int>();
     //   public Dictionary<string, double> productprice = new Dictionary<string, double>(); 
       public double price { get; set; } 
    }
}
