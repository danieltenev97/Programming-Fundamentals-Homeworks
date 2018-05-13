using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            char[] arr1 = a.Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = b.Split(' ').Select(char.Parse).ToArray();

           if(arr1[0]<arr2[0])
            {
                Console.WriteLine(string.Join("",arr1));
                Console.WriteLine(string.Join("", arr2));
            }
           else if(arr1[0]==arr2[0])
            {
                if(arr1.Length>=arr2.Length)
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                }
                else
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                }
            }
           else
            {
                Console.WriteLine(string.Join("", arr2));
                Console.WriteLine(string.Join("", arr1));
            }

        }
    }
}
