using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public interface IRenderer
    {
        void RenderTitle(string title);
        void RenderContent(string content);
        void RenderProduct(string title, string description, string image, int id);
    }
}