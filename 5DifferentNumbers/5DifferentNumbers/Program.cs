using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            int n=0;
            int n1=0;
            int n2=0;
            int n3=0;
            int n4=0;


            for (int i = a; i <=b; i++)
            {

                for (int j =a ; j <=b; j++)
                {
                    for (int k =a; k <=b; k++)
                    {
                        for (int m = a; m <=b; m++)
                        {
                            for (int z = a; z <=b; z++)
                            {
                                if (i >= a)
                                {
                                    n = i;

                                    if (j > i && j < k)
                                    {
                                        n1 = j;

                                        if (k > j && k < m)
                                        {
                                            n2 = k;
                                        
                                        if (m > k && m < z)
                                        {
                                            n3 = m;

                                                if (z > m && z <= b)
                                                {
                                                    n4 = z;

                                                    Console.WriteLine($"{n} {n1} {n2} {n3} {n4}");
                                                    counter++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }

            if(counter==0)
            {
                Console.WriteLine("No");
            }


        }
    }
}
