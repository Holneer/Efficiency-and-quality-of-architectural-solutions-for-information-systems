using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1
{
    public interface IStorage
    {
        void UploadFile(string filePath);
        void DownloadFile(string fileName, string destinationPath);
        void DeleteFile(string fileName);
    }
}