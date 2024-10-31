using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public abstract class Page
    {
        protected IRenderer Renderer;

        protected Page(IRenderer renderer)
        {
            Renderer = renderer;
        }

        public abstract void Render();
    }

}