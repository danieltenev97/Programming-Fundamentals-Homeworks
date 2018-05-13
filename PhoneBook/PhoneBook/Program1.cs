using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> contact = new SortedDictionary<string, string>();
            string[] INFO;
            List<string> contact1 = new List<string>();
            INFO = Console.ReadLine().Split(' ').ToArray();

            while (INFO[0]!="END")
            {

                 
                string first = INFO[0];
                string key = "";
                if (INFO.Length >= 2)
                {
                     key = INFO[1];
                }
                string value = "";
                if(INFO.Length>=3)
                {
                     value = INFO[2];
                }
                switch(first)
                {
                    case "A": if(contact.ContainsKey(key))
                        {

                            
                            contact[key] = value;
                           
                         
                        }
                    else
                        {
                            
                            contact[key] = value;
                            
                        
                        }
                        break;

                    case "ListAll":

                            foreach (var item in contact.OrderBy(n => n.Key))
                            {
                                
                              Console.WriteLine($"{item.Key} -> {item.Value}");
                                
                            
                          
                        }

                        break; 
                }

                 


                INFO = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
