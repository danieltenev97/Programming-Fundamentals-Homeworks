using System;
using System.Text.RegularExpressions;

namespace hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool isFound = false;
            int counter = 1;
           ;int index = 0;
            
            while(isFound!=true)
            {
                var search = Console.ReadLine().Split();
                char searchingelement = char.Parse(search[0]);
                int size = int.Parse(search[1]);
                
                if(!text.Contains(searchingelement.ToString()))
                {
                    continue;
                }
               

                for (int i = 0; i < text.Length-1; i++)
                {
                    if(text[i]==searchingelement&&text[i+1]==searchingelement)
                    {
                        if(counter==1)
                        { index = i; }
                        counter++;
                    }
                    else if(counter<size)
                    {
                        counter = 1;
                    }
                    else
                    {
                        break;
                    }
                }
                if (size <= counter)
                {
                    break;
                }


            }

            Console.WriteLine($"Hideout found at index {index} and it is with size {counter}!");

        }
    }
}
