using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static bool CheckDigitSum(int a)
        {
            int sum = 0;
            int b = 0;
            while(a!=0)
            {
                b = a % 10;
                sum = sum + b;
                a = a / 10;
            }

            if(sum%7==0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        static bool CheckforEvenDigit(int a)
        {
            int counter = 0;
            int b = 0;
            while (a != 0)
            {
                b = a % 10;
                if(b%2==0)
                {
                    counter++;
                }
                a = a / 10;
            }

            if(counter!=0)
            {
                return true;
            }
            else
            {
                return false;
            }

            }

        static bool CheckSymetry(int a)
        {

            string number = a.ToString();

            for (int i = 0; i <number.Length-1; i++)
            {
                if (number[i] == number[number.Length-1-i])
                {
                    continue;
                }

                else
                {
                    return false;
                }
            }

            return true;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool a=false;
            bool b=false;
            bool c = false;

            for (int i = 1; i <=n; i++)
            {
                a = CheckforEvenDigit(i);
                b = CheckDigitSum(i);
                c = CheckSymetry(i);

                if((a==true)&&(b==true)&&(c==true))
                {
                    Console.WriteLine(i);
                }


            }



        }
    }
}
