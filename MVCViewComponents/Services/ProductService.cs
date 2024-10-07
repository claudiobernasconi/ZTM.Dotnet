namespace MVCViewComponents.Services;

public class ProductService : IProductService
{
    public Task<List<Product>> GetTopProductsAsync(int count)
    {
        var products = new List<Product>
        {
            new Product("Laptop", 850),
            new Product("Smartphone", 675),
            new Product("Tablet", 450),
            new Product("Smartwatch", 300),
            new Product("Headphones", 125),
            new Product("Camera", 900),
            new Product("Printer", 375),
            new Product("Monitor", 700),
            new Product("Keyboard", 150),
            new Product("Mouse", 120),
            new Product("Router", 200),
            new Product("External Hard Drive", 600),
            new Product("Speaker", 480),
            new Product("Webcam", 220),
            new Product("Microphone", 340),
        };

        return Task.FromResult(products.Take(count).ToList());
    }
}
