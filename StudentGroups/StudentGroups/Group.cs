using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    class Group
    {
       
        public string town{ get; set; }
        public decimal size { get; set; }
        public Dictionary<string, DateTime> registerdate = new Dictionary<string, DateTime>();
        public Dictionary<string, string> studentinfo = new Dictionary<string, string>();
    }
}
