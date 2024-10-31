using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6
{
    public class CachedDownloader : IDownloader
    {
        private SimpleDownloader _simpleDownloader;
        private Dictionary<string, string> _cache;

        public CachedDownloader(SimpleDownloader simpleDownloader)
        {
            _simpleDownloader = simpleDownloader;
            _cache = new Dictionary<string, string>();
        }

        public string Download(string url)
        {
            if (_cache.ContainsKey(url))
            {
                Console.WriteLine($"[CachedDownloader] Дані для URL '{url}' отримані з кешу.");
                return _cache[url];
            }

            Console.WriteLine($"[CachedDownloader] Дані для URL '{url}' не знайдено в кеші. Виконання завантаження...");
            string data = _simpleDownloader.Download(url);
            _cache[url] = data;

            return data;
        }
    }
}