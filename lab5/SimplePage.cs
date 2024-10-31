using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public class SimplePage : Page
    {
        private string _title;
        private string _content;

        public SimplePage(IRenderer renderer, string title, string content) : base(renderer)
        {
            _title = title;
            _content = content;
        }

        public override void Render()
        {
            Console.WriteLine("[SimplePage] Рендерінг простої сторінки:");
            Renderer.RenderTitle(_title);
            Renderer.RenderContent(_content);
        }
    }
}