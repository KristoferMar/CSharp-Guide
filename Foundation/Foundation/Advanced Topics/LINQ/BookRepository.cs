using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Advanced_Topics.LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO.Net Step by Step", Price = 5},
                new Book() {Title = "ADO.Net MVC", Price = 9.99f},
                new Book() {Title = "ADO.Net Web API", Price = 12},
                new Book() {Title = "C# Advanced Topics", Price = 7},
                new Book() {Title = "C# Advanced Topics", Price = 9}
            };
        }
    }
}
