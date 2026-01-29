using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class AccountGroupApiService : BaseApiService
    {
        //private readonly HttpClient _http;
        public AccountGroupApiService(HttpClient http) : base(http) { }
        //public PartyApiService(IHttpClientFactory factory)
        //{
        //    _http = factory.CreateClient("Api");
        //}

        public async Task<List<AccountGroupDto>> GetAccountGroupsAsync()
        {
            return await _http.GetFromJsonAsync<List<AccountGroupDto>>("api/account-groups");
        }

        public async Task<AccountGroupDto> GetAccountGroupAsync(Guid id)
        {
            return await _http.GetFromJsonAsync<AccountGroupDto>($"api/account-groups/{id}");
        }

        public async Task<HttpResponseMessage> CreateAsync(AccountGroupDto dto)
        {
            return await _http.PostAsJsonAsync("api/account-groups", dto);
        }

        public async Task<HttpResponseMessage> UpdateAsync(Guid id, AccountGroupDto dto)
        {
            return await _http.PutAsJsonAsync($"api/account-groups/{id}", dto);
        }

        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {
            return await _http.DeleteAsync($"api/account-groups/{id}");
        }
    }
}
