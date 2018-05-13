using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            double[] array = new double[length];

            int[] indexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            for (int i = 0; i < indexes.Length; i++)
            {
                if (indexes[i] < length&&indexes[i]>=0)
                {
                    int index = indexes[i];
                    array[index] = 1;
                }
            }
            // Console.WriteLine(string.Join(" ",array));


            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                  
                if (input[0].Equals("end")) break;
                int from = 0;
                int to = 0;
                string direction = "";
                
                    from = int.Parse(input[0]);
                    direction = input[1];
                    to = int.Parse(input[2]);
                
                int index = from;
                if (direction=="left")
                {
                    to *= -1;
                }
                if (index >= length || index < 0)
                {

                    continue;
                }
                if (array[index] == 0)
                {
                    continue;
                }

                array[index] = 0;

                int index1 = index;

                while(true)
                {
                    index1 = index1 + to;
                    if(index1<0||index1>=length)
                    {
                        break;
                    }

                    if(array[index1]==1)
                    {
                        continue;
                    }
                    else
                    {
                        array[index1] = 1;
                        break;
                    }
                }

            }

            Console.WriteLine(string.Join(" ", array));


        }
    }
}
