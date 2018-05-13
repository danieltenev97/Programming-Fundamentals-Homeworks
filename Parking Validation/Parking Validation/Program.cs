using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkregisters = new Dictionary<string, string>();

            int i = 0;
            
          

            while(i<n)
            {
                i++;
                var commands = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                string action = commands[0];
                if(action=="register")
                {
                    string person = commands[1];
                    string licenseplate = commands[2];
                    if(licenseplate.Length!=8)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licenseplate}");
                        continue;
                    }
                    if(!(licenseplate==licenseplate.ToUpper()))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licenseplate}");
                            continue;
                    }
                    string middle = licenseplate.Substring(2, 4);
                    try
                    {
                        int.Parse(middle);
                    }
                    catch
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licenseplate}");
                        continue;
                    }
                    if (parkregisters.ContainsValue(licenseplate))
                    {
                        Console.WriteLine($"ERROR: license plate {licenseplate} is busy");
                        continue;
                    }

                  
                    if(parkregisters.ContainsKey(person))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseplate}");
                        continue;
                    }
                   else if (!parkregisters.ContainsKey(person))
                    {
                        Console.WriteLine($"{person} registered {licenseplate} successfully");
                        parkregisters[person] = licenseplate;
                        continue;
                    }




                }

                else if(action == "unregister")
                {
                    string username = commands[1];
                    if(!parkregisters.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"user {username} unregistered successfully");
                        parkregisters.Remove(username);
                    }
                }


                
            }

            foreach (var item in parkregisters)
            {
                var user = item.Key;
                var lisenceplate = item.Value;

                Console.WriteLine($"{user} => {lisenceplate}");

            }
        }
    }
}
