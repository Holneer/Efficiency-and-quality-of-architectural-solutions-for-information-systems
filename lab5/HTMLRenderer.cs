using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public class HTMLRenderer : IRenderer
    {
        public void RenderTitle(string title)
        {
            Console.WriteLine($"[HTMLRenderer] <h1>{title}</h1>");
        }

        public void RenderContent(string content)
        {
            Console.WriteLine($"[HTMLRenderer] <p>{content}</p>");
        }

        public void RenderProduct(string title, string description, string image, int id)
        {
            Console.WriteLine($"[HTMLRenderer] <div id='product-{id}'><h1>{title}</h1><p>{description}</p><img src='{image}' /></div>");
        }
    }
}