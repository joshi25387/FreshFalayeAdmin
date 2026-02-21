using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class RoleApiService : BaseApiService
    {
        public RoleApiService(HttpClient http) : base(http) { }


        public async Task<List<RoleDto>> GetRolesAsync()
        => await _http.GetFromJsonAsync<List<RoleDto>>("api/roles") ?? new();

        public async Task<HttpResponseMessage> CreateAsync(RoleDto dto)
            => await _http.PostAsJsonAsync("api/roles", dto);

        public async Task<HttpResponseMessage> UpdateAsync(Guid id, RoleDto dto)
            => await _http.PutAsJsonAsync($"api/roles/{id}", dto);

        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
            => await _http.DeleteAsync($"api/roles/{id}");
    }
}
