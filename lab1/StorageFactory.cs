using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1
{
    public class StorageFactory
    {
        public static IStorage CreateStorage(string storageType)
        {
            return storageType switch
            {
                "Local" => new LocalStorage(),
                "AmazonS3" => new AmazonS3Storage(),
                _ => throw new ArgumentException("Unknown storage type")
            };
        }
    }
}