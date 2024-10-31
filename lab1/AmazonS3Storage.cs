using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1
{
    public class AmazonS3Storage : IStorage
    {
        public void UploadFile(string filePath)
        {
            Console.WriteLine($"[AmazonS3Storage] Завантаження файлу: {filePath}");
        }

        public void DownloadFile(string fileName, string destinationPath)
        {
            Console.WriteLine($"[AmazonS3Storage] Завантаження файлу {fileName} у {destinationPath}");
        }

        public void DeleteFile(string fileName)
        {
            Console.WriteLine($"[AmazonS3Storage] Видалення файлу: {fileName}");
        }
    }
}