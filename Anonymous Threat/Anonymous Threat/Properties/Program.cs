using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var list = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
           



            while (true)
            {
                string input = Console.ReadLine();
                if(input== "3:1") { break; }
                var commands = input.Split(' ');

                string command = commands[0];
                int startindex = int.Parse(commands[1]);
                int finalindex = int.Parse(commands[2]);
                if (finalindex > list.Count-1 || finalindex < 0)
                {
                    finalindex = list.Count - 1;
                }
                if (startindex > list.Count-1 || startindex < 0)
                {
                    startindex = 0;
                }

                if (command.Equals("merge"))
                {
                 
                    var concat = string.Join("", list.Skip(startindex).Take(finalindex + 1).ToArray());

                    list.RemoveRange(startindex, finalindex-startindex+1);

                    list.Insert(startindex, concat);
                   
                    
                }

                else if(command.Equals("divide"))
                {
                   
                    List<string> result =divideList(list[startindex], finalindex);
                    list.RemoveAt(startindex);
                    list.InsertRange(startindex, result);

                   
                }
            }
         
          
            Console.WriteLine(string.Join(" ",list));
        }


        static List<string> divideList(string word, int lenght)
        {

            List<string> divide = new List<string>();
            int partsdivide = word.Length / lenght;

            if (word.Length % partsdivide == 0)
            {
                while (word.Length >= partsdivide)
                {
                    string elements = word.Substring(0, partsdivide);
                    divide.Add(elements);
                    word = word.Substring(partsdivide);
                }




                return divide;
            }
            else
            {
                string concat = "";
                concat += divide[divide.Count - 2];
                concat += divide[divide.Count - 1];

                divide.Remove(divide[divide.Count - 1]);
                divide.Remove(divide[divide.Count - 1]);

                divide.Add(concat);
                return divide;

            }
        
        }
    }
}
