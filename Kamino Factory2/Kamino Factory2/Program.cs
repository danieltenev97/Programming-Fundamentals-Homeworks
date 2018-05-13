using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Kamino_Factory2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[5];

            List<Array> arrlist = new List<Array>();

            while(true)
            {
                string input = Console.ReadLine();
                if(input== "Clone them!") { break; }

                array = input.Split(new[] { "!" ,@"[!]+" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                if(!arrlist.Contains(array))
                {
                    arrlist.Add(array);
                }

                
            }
            int counter = 1;
            int maxcounter = 1;
            int sample = 1;
            int sum = 0;
            int bestsum = 0;
            int index = 0;
           
            int[] bestarray = new int[n];

            for (int i = 0; i <arrlist.Count ; i++)
            {
                int[] currentarr = (int[])arrlist[i];
                sum = currentarr.Sum();
                int samplecounter = maxcounter;
                int sampleindex = index;
                for (int j = 0; j <currentarr.Length-1 ; j++)
                {
                    int first = currentarr[j];
                    int second = currentarr[j + 1];
                    
                    if (first == 0 || second == 0) continue;

                    if (first == second)
                    {
                        counter++;
                       
                        if (counter > maxcounter)
                        {
                            
                                index = j;
                            
                            maxcounter = counter;
                        
                        }

                    }
                    else
                    {
                        counter = 1;
                    }


                }

                if(maxcounter==samplecounter&&sampleindex==index)
                {
                    if (sum > bestsum)
                    {
                        bestarray = currentarr;
                    }
                }

                else if(maxcounter==samplecounter)
                {
                    if(sampleindex<index)
                    {
                        bestarray = (int[])arrlist[i];
                    }
                }
                else if(maxcounter>samplecounter)
                {
                    bestarray = (int[])arrlist[i];
                }

               if(sum>bestsum)
                {
                    bestsum = sum;
                }
            }

            foreach (var item in arrlist)
            {
                if (item == bestarray) { break; }

                sample++;
            }
            bestsum = bestarray.Sum();
            Console.WriteLine($"Best DNA sample {sample} with sum: {bestsum}.");
            Console.WriteLine(string.Join(" ",bestarray));
        }
    }
}
