
using FreshFalaye.Admin.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace FreshFalaye.Admin.Services
{
    public class ProductApiService : BaseApiService
    {
        //private readonly HttpClient _http;
       // public ProductApiService(IHttpClientFactory factory) : base(factory) { }
        public ProductApiService(HttpClient http) : base(http) { }

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<ProductDto>>("api/products");
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public async Task<ProductDto> GetProductAsync(Guid id)
        {
            return await _http.GetFromJsonAsync<ProductDto>($"api/products/{id}");
        }

        public async Task<HttpResponseMessage> CreateAsync(ProductDto dto)
        {
            return await _http.PostAsJsonAsync("api/products", dto);            
        }

        public async Task<HttpResponseMessage> UpdateAsync(Guid id, ProductDto dto)
        {
            string json = JsonConvert.SerializeObject(dto);
            return await _http.PutAsJsonAsync($"api/products/{id}", dto);            
        }

        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {
            return await _http.DeleteAsync($"api/products/{id}");            
        }

        // Optional: upload product image
        public async Task<HttpResponseMessage> UploadImageAsync(Guid productId, Stream imageStream, string fileName)
        {
            using var content = new MultipartFormDataContent();
            content.Add(new StreamContent(imageStream), "file", fileName);

            return await _http.PostAsync($"api/products/{productId}/image", content);            
        }
    }
}


