using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int totalpieces = a * b;
            int sum = 0;
            
            while (true)
            {
                string command = Console.ReadLine();
                int b1 = totalpieces - sum;
                if (command.Equals("STOP"))
                {

                    Console.WriteLine($"{b1} pieces are left.");
                    break;
                }

                int takenpieces = int.Parse(command);
                
                sum = sum + takenpieces;
                if(sum>totalpieces)
                {
                    int c = sum - takenpieces;
                    Console.WriteLine($"No more cake left! You need {c} pieces more.");
                    break;
                }


                
            }

        }
    }
}
