using FoodCourtBlazor.Data;
using FoodCourtBlazor.Repository.IRepository;
using FoodCourtBlazor.Services.IService;

namespace FoodCourtBlazor.Services;

public class ProductService(IUnitOfWork unitOfWork) : IProductService
{
    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        var allProducts = await unitOfWork.Product.GetAllAsync(includeProperties:"Category");
        if (allProducts.Any())
        {
            return allProducts;
        }

        return new List<Product>();
    }

    public async Task<Product> GetProduct(Guid productId)
    {
        var obj = await unitOfWork.Product.GetAsync(ca=>ca.Id == productId, includeProperties:"Category");
        if (obj != null)
        {
            return obj;
        }

        return new Product();
    }

    public Task<bool> DeleteProduct(Guid productId)
    {
        throw new NotImplementedException();
    }

    public Task<Product> CreateProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<Product> UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}