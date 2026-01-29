using FreshFalaye.Admin.Models;
using System.Net.Http.Json;

namespace FreshFalaye.Admin.Services
{
    public class AccountApiService : BaseApiService
    {
        //private readonly HttpClient _http;
        public AccountApiService(HttpClient http) : base(http) { }
        //public PartyApiService(IHttpClientFactory factory)
        //{
        //    _http = factory.CreateClient("Api");
        //}

        public async Task<List<AccountDto>> GetAccountsAsync()
        {
            return await _http.GetFromJsonAsync<List<AccountDto>>("api/accounts");
        }

        public async Task<AccountDto> GetAccountAsync(Guid id)
        {
            return await _http.GetFromJsonAsync<AccountDto>($"api/accounts/{id}");
        }

        public async Task<HttpResponseMessage> CreateAsync(AccountDto dto)
        {
            return await _http.PostAsJsonAsync("api/accounts", dto);            
        }

        public async Task<HttpResponseMessage> UpdateAsync(Guid id, AccountDto dto)
        {
            return await _http.PutAsJsonAsync($"api/accounts/{id}", dto);            
        }

        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {
            return await _http.DeleteAsync($"api/accounts/{id}");           
        }
    }
}
