using lab5;

IRenderer htmlRenderer = new HTMLRenderer();
IRenderer jsonRenderer = new JSONRenderer();
IRenderer xmlRenderer = new XMLRenderer();

Page simplePageHtml = new SimplePage(htmlRenderer, "Головна сторінка", "Ласкаво просимо на наш сайт.");
simplePageHtml.Render();

Console.WriteLine();

Product product = new Product(1, "Ноутбук", "Новий ноутбук", "/images/laptop.png");
Page productPageJson = new ProductPage(jsonRenderer, product);
productPageJson.Render();

Console.WriteLine();

Page simplePageXml = new SimplePage(xmlRenderer, "Про нас", "Ми продаємо техніку.");
simplePageXml.Render();