using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public class JSONRenderer : IRenderer
    {
        public void RenderTitle(string title)
        {
            Console.WriteLine($"[JSONRenderer] {{ \"title\": \"{title}\" }}");
        }

        public void RenderContent(string content)
        {
            Console.WriteLine($"[JSONRenderer] {{ \"content\": \"{content}\" }}");
        }

        public void RenderProduct(string title, string description, string image, int id)
        {
            Console.WriteLine($"[JSONRenderer] {{ \"id\": {id}, \"title\": \"{title}\", \"description\": \"{description}\", \"image\": \"{image}\" }}");
        }
    }
}