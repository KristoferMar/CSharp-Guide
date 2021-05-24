using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation.Basic_Topics.Methods
{
    class Program
    {
        static void NonMain(string[] args)
        {
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            Console.WriteLine("Point is at ({0}, {1}) ", point.X, point.Y);
        }
    }
}
