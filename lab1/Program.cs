using lab1;

IStorage amazonS3 = StorageFactory.CreateStorage("AmazonS3");
UserStorageManager storageManager = UserStorageManager.GetInstance(amazonS3);

storageManager.UserStorage.UploadFile("path/to/file");
storageManager.UserStorage.DownloadFile("example.txt", "path/to/download");
storageManager.UserStorage.DeleteFile("example.txt");

IStorage localStorage = StorageFactory.CreateStorage("Local");
storageManager.ChangeStorage(localStorage);

storageManager.UserStorage.UploadFile("path/to/file");
storageManager.UserStorage.DownloadFile("example.txt", "path/to/download");
storageManager.UserStorage.DeleteFile("example.txt");