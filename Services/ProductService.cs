using FoodCourtBlazor.Data;
using FoodCourtBlazor.Repository.IRepository;
using FoodCourtBlazor.Services.IService;
using Microsoft.AspNetCore.Components.Forms;

namespace FoodCourtBlazor.Services;

public class ProductService(IUnitOfWork unitOfWork, IWebHostEnvironment environment) : IProductService
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

    public async Task<bool> DeleteProduct(Guid productId)
    {
        var obj = await unitOfWork.Product.GetAsync(ca => ca.Id == productId, tracked: true);
        if (obj != null)
        {
            if(obj.ImageUrl != null)
            {
                var path = Path.Combine(environment.WebRootPath, obj.ImageUrl.TrimStart('/'));
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            await unitOfWork.Product.Remove(obj);
            return true;
        }

        return false;
    }

    public async Task<Product> CreateProduct(Product product)
    {
        product.CreatedDate = DateTime.UtcNow;
        product.UpdatedDate = DateTime.UtcNow;
        // product.ImageUrl = await SaveImage(product.Image);
        var obj = await unitOfWork.Product.Create(product);
        await unitOfWork.SaveAsync();
        return obj;
    }

    public async Task<Product> UpdateProduct(Product product)
    {
        var obj = await unitOfWork.Product.GetAsync(ca => ca.Id == product.Id, tracked: true);
        if (obj != null)
        {
            obj.Name = product.Name;
            obj.Description = product.Description;
            obj.SpecialTag = product.SpecialTag;
            obj.Price = product.Price;
            obj.CategoryId = product.CategoryId;
            obj.AvailableQuantity = product.AvailableQuantity;
            obj.IsAvailable = product.IsAvailable;
            obj.UpdatedDate = DateTime.UtcNow;
            obj.ImageUrl = product.ImageUrl;
            await unitOfWork.SaveAsync();
            return obj;
        }

        return product;
    }
    
    private async Task<string> SaveImage(IBrowserFile? image)
    {
        var directoryPath = Path.Combine(environment.WebRootPath, "images", "Product");
        
        if (image != null)
        {
            FileInfo fileInfo = new (image.Name);
            var fileName = $"{Guid.NewGuid()}_{DateTime.UtcNow:yyyyMMdd}{Path.GetExtension(fileInfo.Name)}";

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            var path = Path.Combine(directoryPath, fileName);
            await using FileStream fileStream = new (path, FileMode.Create);
            await image.OpenReadStream(image.Size).CopyToAsync(fileStream);
            return $"/images/Product/{fileName}";
        }
        return string.Empty;
    }
}