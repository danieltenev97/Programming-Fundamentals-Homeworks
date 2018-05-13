using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendList
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] delimiter = " ".ToCharArray();

            List<string> list= Console.ReadLine().Split('|').ToList();

            List<string> result = new List<string>();
            list.Reverse();

            for (int i = 0; i <list.Count; i++)
            {
                List<string> intlist = list[i].Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToList();

                result.AddRange(intlist);
            }



            Console.WriteLine(string.Join(" ", result));


        }
    }
}
