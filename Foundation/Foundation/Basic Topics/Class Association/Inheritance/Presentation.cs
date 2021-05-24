using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Class_Association.Inheritance
{
    public class Presentation
    {
        public int With { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Objects copied to clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}
