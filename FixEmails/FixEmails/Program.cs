using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            int i = 1;
            string key = "";
            string value = "";
            
             while(text!="stop")
            {
                if(i%2!=0)
                {
                    key = text;
                }
                else
                {
                    value = text;
                    if(value.EndsWith("uk")||value.EndsWith("us"))
                    {
                       
                    }
                    else
                    {
                        dictionary[key] = value;
                    }

                    
                   
                    
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
