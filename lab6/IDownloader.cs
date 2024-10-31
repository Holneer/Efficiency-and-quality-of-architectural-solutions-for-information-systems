using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab6
{
    public interface IDownloader
    {
        string Download(string url);
    }
}