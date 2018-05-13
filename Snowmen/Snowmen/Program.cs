using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {

      List<int> snowmen = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            int attacker = 0;
            int target = 0;

            List<int> losers= new List<int>();

             while(snowmen.Count!=1)
              {
                int count = snowmen.Count;
                if (count == 2)
                {
                    for (int i = 0; i <2; i++)
                    {
                        attacker = i;
                        if (snowmen[i] >= count)
                        {
                            snowmen[i] = snowmen[i] % count;
                        }
                        target = snowmen[i];
                      if(attacker==target)
                        {
                            losers.Add(attacker);
                            Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                            break;
                        }



                    }

                }
                else
                {
                    for (int j = 0; j < count; j++)
                    {
                        attacker = j;
                        if (snowmen[j] >= count)
                        {
                            snowmen[j] = snowmen[j] % count;
                        }
                        target = snowmen[j];


                        int battle = Math.Max(attacker, target) - Math.Min(attacker, target);

                        if (attacker == target)
                        {
                            losers.Add(target);
                            Console.WriteLine($"{attacker} performed harakiri");
                        }

                        if (battle % 2 == 0 )
                        {
                            losers.Add(target);
                            Console.WriteLine($"{attacker} x {target} -> {attacker} wins");

                        }

                        else if (battle % 2 != 0 && (!losers.Contains(j)))
                        {
                            losers.Add(attacker);
                            Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        }


                    }
                }

                losers.Sort();
                losers.Reverse();
            for (int i = 0; i < losers.Count; i++)
            {
                int index = losers[i];
                snowmen.RemoveAt(index);
            }

                losers.Clear();

           // Console.WriteLine(string.Join(" ",snowmen));

               
              }

            

         
        }
    }
}
