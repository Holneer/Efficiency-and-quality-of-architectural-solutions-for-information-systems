using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public class XMLRenderer : IRenderer
    {
        public void RenderTitle(string title)
        {
            Console.WriteLine($"[XMLRenderer] <title>{title}</title>");
        }

        public void RenderContent(string content)
        {
            Console.WriteLine($"[XMLRenderer] <content>{content}</content>");
        }

        public void RenderProduct(string title, string description, string image, int id)
        {
            Console.WriteLine($"[XMLRenderer] <product id='{id}'><title>{title}</title><description>{description}</description><image>{image}</image></product>");
        }
    }
}