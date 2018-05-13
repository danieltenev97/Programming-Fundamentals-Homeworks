using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {

         
            long health = long.Parse(Console.ReadLine());
            string virus = Console.ReadLine();

          

            List<string> list = new List<string>();
            bool isBeaten = true;

            double lefthealth = health;
           while (virus!="end")
            {
                double timetoheal = 0;
                
                for (int i = 0; i < virus.Length; i++)
                {
                    char a = virus[i];

                    timetoheal = timetoheal + (int)a;
                }
                timetoheal = Math.Floor(timetoheal / 3);
                double tseconds = 0;

                if (list.Contains(virus))
                {
                    tseconds = Math.Floor((timetoheal * virus.Length) / 3);
                }

                else
                {
                    tseconds = timetoheal * virus.Length;
                }

                lefthealth = lefthealth - Math.Floor(tseconds);

                Console.WriteLine($"Virus {virus}: {timetoheal} => {tseconds} seconds");
                if (lefthealth<0)
                {
                    isBeaten = false;
                    break;
                }
                list.Add(virus);
                int minutes= (int)Math.Floor(tseconds / 60);
                int seconds= (int)Math.Floor(tseconds % 60);

                
                Console.WriteLine($"{virus} defeated in {minutes}m {seconds}s.");
                Console.WriteLine($"Remaining health: {lefthealth}");

               lefthealth = lefthealth + lefthealth * 0.20;
                lefthealth = Math.Floor(lefthealth);
                virus = Console.ReadLine();


            }

           if(isBeaten==true)
            {
                Console.WriteLine($"Final Health: {lefthealth}");
            }

           else
            {
                Console.WriteLine("Immune System Defeated.");
            }


       


            


           

            

        }



    }
}
