using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static int Getmax(int a, int b)
        {
            return Math.Max(a,b);
        }

        static char Getmax(char a,char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
           
        }

        static string Getmax(string a,string b)
        {
            int c = string.Compare(a, b);

            if (c>0)
            {
                return a;
            }
            else
            {
                return b;
            }

        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
          
            if(type.Equals("int"))
            {

               int a = int.Parse(Console.ReadLine());
               int b = int.Parse(Console.ReadLine());

                int result =Getmax(a,b);
                Console.WriteLine(result);

              }

            else if (type.Equals("char"))
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());

                char result = Getmax(a, b);
                Console.WriteLine(result);
            }

            else
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                string result = Getmax(a, b);
                Console.WriteLine(result);
            }

        }
    }
}
