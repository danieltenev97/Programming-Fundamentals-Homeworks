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
            Dictionary<string, string> contact = new Dictionary<string, string>();
            string[] INFO;
            List<string> contact1 = new List<string>();
            INFO = Console.ReadLine().Split(' ').ToArray();

            while (INFO[0]!="END")
            {
                string first = INFO[0];
                string key = INFO[1];
                string value = "";
                if(INFO.Length>=3)
                {
                     value = INFO[2];
                }
                switch(first)
                {
                    case "A": if(contact.ContainsKey(key))
                        {
                            string a = " -> ";
                            contact[key] = value;
                            string sum = a + value;
                            Console.WriteLine(sum);
                        }
                    else
                        {
                            contact[key] = value;
                        }
                        break;

                 /*   case "S":

                        if (contact.ContainsKey(key))
                        {
                            foreach (var item in contact)
                            {
                                if (item.Key == key)
                                {
                                //    Console.WriteLine($"{key} -> {item.Value}");
                                }
                            }
                          
                        }

                        else
                        {
                         //   Console.WriteLine($"Contact {key} does not exist.");
                        }


                            break;
                }

             */
                INFO = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
