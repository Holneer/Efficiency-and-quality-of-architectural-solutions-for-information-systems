using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6
{
    public class SimpleDownloader : IDownloader
    {
        public string Download(string url)
        {
            Console.WriteLine($"[SimpleDownloader] Завантаження даних з URL: {url}");
            return $"Data from {url}";
        }
    }
}