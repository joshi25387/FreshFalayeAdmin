using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class UserApiService : BaseApiService
    {
        public UserApiService(HttpClient http) : base(http) { }

        // GET all users
        public async Task<List<UserDto>> GetUsersAsync()
        {
            return await _http.GetFromJsonAsync<List<UserDto>>("api/user") ?? new();
        }

        // CREATE user
        public async Task<HttpResponseMessage> CreateAsync(UserDto dto)
        {
            return await _http.PostAsJsonAsync("api/user", dto);
        }

        // UPDATE user
        public async Task<HttpResponseMessage> UpdateAsync(Guid id, UserDto dto)
        {
            return await _http.PutAsJsonAsync($"api/user/{id}", dto);
        }

        // DELETE user
        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {
            return await _http.DeleteAsync($"api/user/{id}");
        }
    }
}
