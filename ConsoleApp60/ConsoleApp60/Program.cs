using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {

            char firstletter = char.Parse(Console.ReadLine().ToUpper());
            char secondletter = char.Parse(Console.ReadLine().ToLower());
            char thirdletter = char.Parse(Console.ReadLine().ToLower());
            char fourthletter = char.Parse(Console.ReadLine().ToLower());
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            
            
            if (n < 0 || n > 9) return;

            for (char i = 'A'; i < firstletter; i++)
            {

            
                for (char j = 'a'; j < secondletter; j++)
                {
               
                    for (char k = 'a'; k < thirdletter; k++)

                    {
                    
                        for (char m = 'a'; m < fourthletter; m++)
                        {
                     
                            for (int z = 0; z < 10; z++)
                            {

                                counter++;
                            }
                            counter++;
                        }
                        counter++;
                    }
                    counter++;
                }




                counter++;

            }
            
            

            if (firstletter == 'A') { Console.WriteLine(0); }
            else

            {
                Console.WriteLine(counter);
                
            }


        }
    }
}
