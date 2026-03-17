using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product("Пирожок", "с котятами", 50, "/images/mem.jpg"),
            new Product("Чебурек", "с вишней", 80, "https://optim.tildacdn.com/tild3635-3764-4331-b832-633037643133/-/resize/340x/-/format/webp/cheb.png.webp"),
            new Product("Тортик", "медовик", 90, "https://foodmood.ru/upload/iblock/f18/f18a6cb201f83cf11e2cc72f694eb3d6.jpg")
        };

        public List<Product> GetAll()
        { 
            return products;
        }

        public Product? TryGetById(Guid id)
        {
            return products.FirstOrDefault(product => product.Id == id);
        }
    }
}
