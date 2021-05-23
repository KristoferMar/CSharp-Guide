using Foundation.Advanced_Topics;
using Foundation.Advanced_Topics.Delegates;
using Foundation.Advanced_Topics.LINQ;
using System.Linq;
using System;

namespace Foundation
{
    class Program
    {
        static void Main(string[] args)
        {

            //Generics
            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<String>();
            //books.Add("A tring");

            // Delegates
            //var processor = new PhotoProcessor();
            //var filters = new PhotoFilters();
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            //filterHandler += filters.ApplyContrast; // Easily adding additional filter
            //filterHandler += RemoveRedEyeFilter;

            //processor.Process("photo.jpg", filterHandler);

        }

        // Custom filter created for delegate
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
