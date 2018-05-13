using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "Odd")
                {
                    for (int i = 0; i < number.Count; i++)
                    {
                        if (number[i] % 2 != 0)
                        {
                            Console.Write(number[i] + " ");
                        }
                    }
                    break;
                }
                if (command == "Even")
                {
                    for (int i = 0; i < number.Count; i++)
                    {
                        if (number[i] % 2 == 0)
                        {
                            Console.Write(number[i] + " ");
                        }
                    }
                    break;
                }

                string[] command1 = command.Split(' ').ToArray();
                if (command1[0].Equals("Delete"))
                {
                    int a = int.Parse(command1[1]);
                    for (int i = 0; i <number.Count; i++)
                    {
                        number.Remove(a);

                    }
                   
                }
                else if (command1[0].Equals("Insert"))
                {
                    int element = int.Parse(command1[1]);
                    int index = int.Parse(command1[2]);
                    number.Insert(index, element);

                }

               

           
                command = Console.ReadLine();
            }
        }
    }
}
