using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class RolePermissionApiService : BaseApiService
    {
        public RolePermissionApiService(HttpClient http) : base(http) { }

        public async Task<List<RolePermissionDto>> GetAsync(Guid roleId)
        {
            return await _http.GetFromJsonAsync<List<RolePermissionDto>>(
                $"api/RolePermission/{roleId}") ?? new();
        }

        // SAVE role permissions (Create + Edit + Delete)
        public async Task<HttpResponseMessage> SaveAsync(Guid roleId, List<RolePermissionDto> list)
        {
            return await _http.PostAsJsonAsync(
                $"api/RolePermission/{roleId}", list);
        }
    }
}
