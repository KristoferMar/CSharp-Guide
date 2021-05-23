using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation.Advanced_Topics.LINQ
{
    class Program
    {
        static void NonMain(string[] args)
        {
            // LINQ
            var books = new BookRepository().GetBooks();

            // LINQ Query Operator
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            // LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
                //Console.WriteLine(book.Title + " " + book.Price);
            }

            // Get a single book
            var book1 = books.Single(b => b.Title == "ASP.NET MVC");

            var book2 = books.First(b => b.Title == "C# Advanced Topics");
            var book2Default = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");

            var book3 = books.Last(b => b.Title == "C# Advanced Topics");

            var book4 = books.Skip(2).Take(3);
        }
    }
}
