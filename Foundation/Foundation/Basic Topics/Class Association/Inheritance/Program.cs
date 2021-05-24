using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Class_Association.Inheritance
{

    public class Text : Presentation
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We created a hyperlink");
        }
    }

    class Program
    {
        static void NonMain(string[] args)
        {
            var text = new Text();
            text.With = 100;
            text.Copy();
        }
    }
}
