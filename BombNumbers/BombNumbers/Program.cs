using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
        //    List<int> leftnumbers = new List<int>();
            int[] bombnumbers= Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if(bombnumbers.Length>2)
            {
                return;
            }
            ;
            int specialnumber = bombnumbers[0];
            int ToDelete = bombnumbers[1];
            int specialindex = 0;
            int index = 0;
            int index1 = 0;
       

            for (int i = 0; i <numbers.Count; i++)
               {
             
                if (numbers[i] == specialnumber)
                {
                    specialindex = i;
                    index = specialindex - ToDelete;
                    index1 = specialindex + ToDelete;
                    for (int j = specialindex; j <= Math.Min(index1,numbers.Count-1); j++)
                    {
                        numbers[j] = 0;
                    }
                    if (index<0)
                    {
                        for (int k = specialindex; k >= 0; k--)
                        {
                            numbers[k] = 0;
                        }
                    }
                    else
                    {
                        for (int k = specialindex; k >= index; k--)
                        {
                            numbers[k] = 0;
                        }
                    }


                }
            
               
               }


          //  Console.WriteLine(string.Join(" ",numbers));





            decimal result = numbers.Sum();
            Console.WriteLine(result);

        }
    }
}
