using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Foundation.Advanced_Topics.Asynchronous_Programming
{
    public class File
    {

        public void DownloadFileSyncronous(string url)
        {
            Console.WriteLine("Downloaded " + url + " synchronosly");
        }
        public static async Task DownloadHtmlAsync(string url)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Downloading " + url + " ....");
                Thread.Sleep(2000);
                Console.WriteLine("File finished downloading!");
            });
        }

        public static async Task GetStuffAsync(string someUrl)
        {
            var getHtmlTask = File.DownloadHtmlAsync("some website " + someUrl);
            await getHtmlTask;
            var myString = "some string";
            Console.WriteLine(myString);
        }
    }
}
