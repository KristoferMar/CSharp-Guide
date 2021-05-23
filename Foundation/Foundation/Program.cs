using Foundation.Advanced_Topics;
using System;

namespace Foundation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Generics
            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<String>();
            books.Add("A tring");
        }
    }
}
