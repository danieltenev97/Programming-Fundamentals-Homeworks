using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string[] arr1 = Console.ReadLine().Split(' ');

            int counter = 1;
            int counter1 = 0;

            if (arr.Length >= arr1.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr1.Length; j++)
                    {


                        if (i != arr.Length - 1 && j != arr1.Length - 1)
                        {
                            if (arr[i] == arr1[j] && arr[i + 1] == arr1[j + 1])
                            {
                                counter++;

                            }

                        }

                    }

                }
                    for (int k = arr.Length - 1; k > 1; k--)
                    {
                        for (int m = arr1.Length - 1; m > 1; m--)
                        {



                            if (arr[arr.Length - 1] == arr1[arr1.Length - 1] && arr[k - 1] == arr1[m - 1])
                            {
                                counter1++;

                            }



                        }

                    }
                
            }

            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {


                        if (i != arr1.Length - 1 && j != arr.Length - 1)
                        {
                            if (arr1[i] == arr[j] && arr1[i + 1] == arr[j + 1])
                            {
                                counter++;

                            }

                        }

                    }
                }
                for (int k = arr1.Length - 1; k > 1; k--)
                {
                    for (int m = arr.Length - 1; m > 1; m--)
                    {



                        if (arr[arr.Length - 1] == arr1[arr1.Length - 1] && arr[m - 1] == arr1[k - 1])
                        {
                            counter1++;

                        }



                    }

                }
            }

                if(counter==1&&counter1==1)
                {
                Console.WriteLine(0);
                return;
                }

                Console.WriteLine(Math.Max(counter,counter1));

            }
        }
    }

