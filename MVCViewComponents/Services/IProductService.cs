namespace MVCViewComponents.Services;

public record Product(string Name, decimal Price);

public interface IProductService
{
    Task<List<Product>> GetTopProductsAsync(int count);
}
