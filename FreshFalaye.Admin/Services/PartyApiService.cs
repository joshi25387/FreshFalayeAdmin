using FreshFalaye.Admin.Models;
using System.Net.Http.Json;

namespace FreshFalaye.Admin.Services
{
    public class PartyApiService : BaseApiService
    {
        //private readonly HttpClient _http;
        public PartyApiService(HttpClient http) : base(http) { }
        //public PartyApiService(IHttpClientFactory factory)
        //{
        //    _http = factory.CreateClient("Api");
        //}

        public async Task<List<PartyDto>> GetPartiesAsync()
        {
            return await _http.GetFromJsonAsync<List<PartyDto>>("api/parties");
        }

        public async Task<PartyDto> GetPartyAsync(int id)
        {
            return await _http.GetFromJsonAsync<PartyDto>($"api/parties/{id}");
        }

        public async Task<HttpResponseMessage> CreateAsync(PartyDto dto)
        {
            return await _http.PostAsJsonAsync("api/parties", dto);            
        }

        public async Task<HttpResponseMessage> UpdateAsync(int id, PartyDto dto)
        {
            return await _http.PutAsJsonAsync($"api/parties/{id}", dto);            
        }

        public async Task<HttpResponseMessage> DeleteAsync(int id)
        {
            return await _http.DeleteAsync($"api/parties/{id}");           
        }
    }
}
