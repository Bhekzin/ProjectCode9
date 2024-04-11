using ProjectCode9.Models;
using System.Net.Http;

namespace ProjectCode9.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
             this._httpClient = httpClient;
        }

        //Test for push
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<Product[]>("api/product/getproducts");
        }
    }
}
