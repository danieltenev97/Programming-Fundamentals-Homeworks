using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var bytes = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int i = 0; i < bytes.Count; i++)
            {
                if (bytes[i].Length != 2)
                {
                    bytes.Remove(bytes[i]);
                }

            }

            List<string> reversedbytes = new List<string>();
            for (int i = 0; i < bytes.Count; i++)
            {
                char[] arr = bytes[i].ToCharArray();
                Array.Reverse(arr);

                arr = arr.ToArray();

                string a = "";
                for (int j = 0; j < arr.Length; j++)
                {
                    a = a + arr[j];
                }
                reversedbytes.Add(a);
            }

            // Console.WriteLine(string.Join(" ",reversedbytes));

            List<string> characterbytes = new List<string>();

            for (int i = 0; i < reversedbytes.Count; i++)
            {
                var number = Convert.ToUInt32(reversedbytes[i], 16);
                if (number > 0 && number <= 255)
                {
                    var hech = Convert.ToChar(number).ToString();

                    characterbytes.Add(hech);
                }

            }

            characterbytes.Reverse();

            Console.WriteLine(string.Join("", characterbytes));





        }
    }
}