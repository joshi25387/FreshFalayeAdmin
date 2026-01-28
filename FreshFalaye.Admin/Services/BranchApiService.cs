using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class BranchApiService : BaseApiService
    {
        public BranchApiService(HttpClient http) : base(http) { }

        // ===============================
        // LIST BRANCHES (Future Grid)
        // ===============================
        public async Task<List<BranchDto>> GetBranchesAsync()
        {
            var response = await _http.GetAsync("api/branches");
            return await ReadResponse<List<BranchDto>>(response);
        }
    }
}
