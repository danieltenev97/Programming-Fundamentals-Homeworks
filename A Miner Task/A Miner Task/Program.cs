using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> dictionary= new Dictionary<string, int>();

            string text = Console.ReadLine();
            int i = 1;
            string key = "";
            int value = 0;
            while(text!="stop")
            {
                if(i%2!=0)
                {
                    
                    key = text;
                }
                else
                {
                     value = int.Parse(text);
                    if (dictionary.ContainsKey(key))
                    {
                        dictionary[key] = dictionary[key] + value;
                    }
                    else
                        dictionary[key] = value;
                    
                }
                text = Console.ReadLine();
                i++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
                
                }
    }
}
