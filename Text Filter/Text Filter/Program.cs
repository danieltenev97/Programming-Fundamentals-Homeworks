using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var banned = Console.ReadLine().Split(new[] { ',',' ' },StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine();

            int n = text.Length;

            foreach (var word in banned)
            {
                var replacement = new string('*',word.Length);
                text = text.Replace(word, replacement);
            }
            


            Console.WriteLine(text);
        }
    }
}
