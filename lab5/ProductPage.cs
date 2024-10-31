using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5
{
    public class ProductPage : Page
    {
        private Product _product;

        public ProductPage(IRenderer renderer, Product product) : base(renderer)
        {
            _product = product;
        }

        public override void Render()
        {
            Console.WriteLine("[ProductPage] Рендерінг сторінки товару:");
            Renderer.RenderProduct(_product.Name, _product.Description, _product.Image, _product.Id);
        }
    }

}