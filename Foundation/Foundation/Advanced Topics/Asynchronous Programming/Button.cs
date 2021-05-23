using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Advanced_Topics.Asynchronous_Programming
{
    public class Button
    {
        public void ButtonPresed()
        {
            File.DownloadHtmlAsync("photo.png");

            File.GetStuffAsync("en url");
        }
    }
}
