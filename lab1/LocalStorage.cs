using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1
{
    public class LocalStorage : IStorage
    {
        public void UploadFile(string filePath)
        {
            Console.WriteLine($"[LocalStorage] Завантаження файлу: {filePath}");
        }

        public void DownloadFile(string fileName, string destinationPath)
        {
            Console.WriteLine($"[LocalStorage] Завантаження файлу {fileName} у {destinationPath}");
        }

        public void DeleteFile(string fileName)
        {
            Console.WriteLine($"[LocalStorage] Видалення файлу: {fileName}");
        }
    }
}