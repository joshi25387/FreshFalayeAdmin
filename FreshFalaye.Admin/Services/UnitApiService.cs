using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class UnitApiService : BaseApiService
    {
        //private readonly HttpClient _http;

        public UnitApiService(HttpClient http) : base(http) { }
        //public UnitApiService(IHttpClientFactory factory)
        //{
        //    _http = factory.CreateClient("Api");
        //}

        public async Task<List<UnitDto>> GetUnitsAsync()
        {
            return await _http.GetFromJsonAsync<List<UnitDto>>("api/units");
        }

        public async Task<UnitDto> GetUnitAsync(int id)
        {
            return await _http.GetFromJsonAsync<UnitDto>($"api/units/{id}");
        }

        public async Task<HttpResponseMessage> CreateUnitAsync(UnitDto dto)
        {
            return await _http.PostAsJsonAsync("api/units", dto);            
        }

        public async Task<HttpResponseMessage> UpdateUnitAsync(int id, UnitDto dto)
        {
            return await _http.PutAsJsonAsync($"api/units/{id}", dto);            
        }

        public async Task<HttpResponseMessage> DeleteUnitAsync(int id)
        {
            return await _http.DeleteAsync($"api/units/{id}");            
        }
    }

}
