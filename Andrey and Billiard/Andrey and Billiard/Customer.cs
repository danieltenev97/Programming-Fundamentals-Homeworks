using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrey_and_Billiard
{
    class Customer
    {
       public   string name { get; set; }
    
      public SortedDictionary<string, int> quantity { get; set; }
      public double bill { get; set; }


        public Customer(string name, SortedDictionary<string, int> quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }


    }
}
