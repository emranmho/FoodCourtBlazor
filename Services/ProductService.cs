using FoodCourtBlazor.Data;
using FoodCourtBlazor.Repository.IRepository;
using FoodCourtBlazor.Services.IService;

namespace FoodCourtBlazor.Services;

public class ProductService(IUnitOfWork unitOfWork) : IProductService
{
    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        var allProducts = await unitOfWork.Product.GetAll(includeProperties:"Category");
        if (allProducts.Any())
        {
            return allProducts;
        }

        return new List<Product>();
    }

    public Task<Product> GetProduct(Guid productId)
    {
        throw new NotImplementedException();
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