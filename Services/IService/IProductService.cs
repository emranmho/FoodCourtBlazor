using FoodCourtBlazor.Data;

namespace FoodCourtBlazor.Services.IService;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProducts();
    Task<Product> GetProduct(Guid productId);
    Task<bool> DeleteProduct(Guid productId);
    Task<Product> CreateProduct(Product product);
    Task<Product> UpdateProduct(Product product);
}