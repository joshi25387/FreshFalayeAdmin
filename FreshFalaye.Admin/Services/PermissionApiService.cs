using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class PermissionApiService : BaseApiService
    {
        public PermissionApiService(HttpClient http) : base(http) { }
       
        public async Task<List<PermissionDto>> GetPermissionsAsync()
        {
            return await _http.GetFromJsonAsync<List<PermissionDto>>("api/permissions") ?? new();
        }

        public async Task<PermissionDto> GetPermissionAsync(Guid id)
        {
            return await _http.GetFromJsonAsync<PermissionDto>($"api/permissions/{id}");
        }

        public async Task<HttpResponseMessage> CreateAsync(PermissionDto dto)
        {
            return await _http.PostAsJsonAsync("api/permissions", dto);
        }

        public async Task<HttpResponseMessage> UpdateAsync(Guid id, PermissionDto dto)
        {
            return await _http.PutAsJsonAsync($"api/permissions/{id}", dto);
        }

        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {
            return await _http.DeleteAsync($"api/permissions/{id}");
        }

        public async Task<HttpResponseMessage> CreateModulePermissionsAsync(string module)
        { 
            return await _http.PostAsJsonAsync("api/permissions/create-module", module);
        }


        public async Task<List<string>> GetModulesAsync()
        { 
            return await _http.GetFromJsonAsync<List<string>>("api/permissions/modules") ?? new();
        }


        public async Task<HttpResponseMessage> DeleteModuleAsync(string module)
        { 
            return await _http.DeleteAsync($"api/permissions/delete-module/{module}");
        }
        

    }
}
