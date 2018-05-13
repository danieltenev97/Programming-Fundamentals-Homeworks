using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listnumbers = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> listnumbers1 = new List<int>();
          int[] arr = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if (arr.Length > 3)
            {
             return;
                    }
            int couunter = arr[0];
            int elementstoDelete = arr[1];
            int elementosearch = arr[2];
            bool isFound = false;
            for (int i = 0; i <listnumbers.Count; i++)
            {
                
             if(i>=elementstoDelete)
                {
                    listnumbers1.Add(listnumbers[i]);
                }
            }
            for (int i = 0; i <Math.Min(couunter,listnumbers1.Count) ; i++)
            {
                if(listnumbers1[i]==elementosearch)
                {
                    isFound = true;
                }
            }

            if(isFound==true)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

         //   Console.WriteLine(string.Join(" ",listnumbers1));
        }
    }
}
