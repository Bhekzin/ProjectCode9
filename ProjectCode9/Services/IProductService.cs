using ProjectCode9.Models;

namespace ProjectCode9.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<IEnumerable<Product>> AddProductAsync();
    }
}
