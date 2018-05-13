using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //   var libraries = new Library();
            var book = new List<Book>();
           // libraries.list = new List<Book>();

            for (int i = 0; i <n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var books = new Book()
                {
                    title = input[0],
                    author = input[1],
                    publisher = input[2],
                    releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBNnumber = input[4],
                    price = double.Parse(input[5])
                 };

                //   libraries.name = books.title;

                book.Add(books);
              //  libraries.list.Add(books);
             }

            string inputdate = Console.ReadLine();
            DateTime date = DateTime.ParseExact(inputdate, "dd.MM.yyyy", CultureInfo.InvariantCulture);


            /*     for (int i = 0; i <libraries.list.Count; i++)
                 {
                    for (int j =i+1 ; j < libraries.list.Count; j++)
                     {

                         if(libraries.list[i].author.Equals(libraries.list[j].author))
                         {
                             libraries.list[i].price = libraries.list[i].price + libraries.list[j].price;
                             libraries.list.Remove(libraries.list[j]);
                         }

                     }
                 }   */

            Library mylibrary = new Library();
            mylibrary.list = book;
            
            string outputFormat = "dd.MM.yyyy";

            /*   foreach (var item in mylibrary.list.GroupBy(x=>x.author)
                   .OrderByDescending(x=>x.Sum(y=>y.price)).ThenBy(x=>x.Key))
               {




                       //  Console.WriteLine($"{item.Key} -> {item.Sum(x => x.price):F2}");




               } */
            var newlist = new List<Book>();

            for (int i = 0; i < book.Count; i++)
            {
                var datecompare = DateTime.Compare(date, book[i].releaseDate);

                if(datecompare<0)
                {
                    newlist.Add(book[i]);
                }
            }

            mylibrary.list = newlist;


            foreach (var book1 in mylibrary.list.OrderBy(x=>x.releaseDate).ThenBy(x=>x.title))
            {
                Console.WriteLine($"{book1.title} -> {book1.releaseDate.ToString(outputFormat)}");
            } 

        }
    }
}
