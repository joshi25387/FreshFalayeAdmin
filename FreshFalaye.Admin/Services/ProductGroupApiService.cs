using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class ProductGroupApiService : BaseApiService
    {
        //private readonly HttpClient _http;

        public ProductGroupApiService(HttpClient http) : base(http) { }
        //public ProductGroupApiService(IHttpClientFactory factory)
        //{
        //    _http = factory.CreateClient("Api");
        //}

        public async Task<List<ProductGroupDto>> GetGroupsAsync()
            => await _http.GetFromJsonAsync<List<ProductGroupDto>>("api/product-groups/flat");

        public async Task<HttpResponseMessage> CreateAsync(ProductGroupDto dto)
            => await _http.PostAsJsonAsync("api/product-groups", dto);

        public async Task<HttpResponseMessage> UpdateAsync(Guid id, ProductGroupDto dto)
            => await _http.PutAsJsonAsync($"api/product-groups/{id}", dto);

        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
            => await _http.DeleteAsync($"api/product-groups/{id}");
    }

}
