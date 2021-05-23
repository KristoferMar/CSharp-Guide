using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, i am {1}", to, Name);
        }

        // Instance method
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
}
