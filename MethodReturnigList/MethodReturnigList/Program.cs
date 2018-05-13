using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodReturnigList
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> listofnumbers = new List<int>();

            for (int i = 0; i <n ; i++)
            {
                listofnumbers.Add(int.Parse(Console.ReadLine()));
            }

          
          listofnumbers= Returndigits(listofnumbers);
            Console.WriteLine(string.Join(" ",listofnumbers));
        }

        public static List<int> Returndigits(List<int> numbers)
        {
            List<int> newnumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i]%2==0)
                {
                    newnumbers.Add(numbers[i]);
                }
            }

            return newnumbers;
        }
    }
}
