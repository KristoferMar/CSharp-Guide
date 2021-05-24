using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Classes
{
    class Program
    {
        static void NonMain(string[] args)
        {
            var person = new Person();
            var p = Person.Parse("John2");
            person.Name = "John";
            person.Introduce("Kristofer");
        }
    }
}
