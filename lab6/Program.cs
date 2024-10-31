using lab6;

SimpleDownloader simpleDownloader = new SimpleDownloader();
IDownloader cachedDownloader = new CachedDownloader(simpleDownloader);

string url = "https://example.com/data";
Console.WriteLine(cachedDownloader.Download(url));

Console.WriteLine();

Console.WriteLine(cachedDownloader.Download(url));

Console.WriteLine();

url = "https://example.com/data2";
Console.WriteLine(cachedDownloader.Download(url));