using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BookLibrary1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var library = new Library();
            List<Books> list = new List<Books>();
         

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                bool containts = false;
                var currentbook = new Books()
                {
                    title = input[0],
                    author = input[1],
                    publisher = input[2],
                    releasedate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    IBMnumber=input[4],
                    price=double.Parse(input[5])
                };

            /*    foreach (var item in list)
                {
                    var autohorname = item.author;
                    if(autohorname==currentbook.author)
                    {
                        item.price = item.price + currentbook.price;
                        containts = true;
                    }
                } */

                if(containts!=true)
                list.Add(currentbook);

                

             }

            DateTime date = DateTime.ParseExact(Console.ReadLine()
                , "dd.MM.yyyy", CultureInfo.InvariantCulture);
           

            library.bookslist = list;



            /*       foreach(var booksprice in library.bookslist.OrderByDescending(a=>a.price).ThenBy(a=>a.author))
                   {
                       var author = booksprice.author;
                       var price = booksprice.price;

                       Console.WriteLine($"{author} -> {price:f2}");

                   } */

            foreach (var item in list.OrderBy(a=>a.releasedate).ThenBy(a=>a.title))
            {
                var title = item.title;
                var bookdate = item.releasedate;

                if(date<bookdate)
                {
                    Console.WriteLine($"{title} -> {bookdate.ToString("dd.MM.yyyy")}");
                }
            }
            

       }

       
    }
}
