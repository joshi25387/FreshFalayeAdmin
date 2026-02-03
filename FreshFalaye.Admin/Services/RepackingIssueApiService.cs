using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class RepackingIssueApiService : BaseApiService
    {
        public RepackingIssueApiService(HttpClient http) : base(http) { }

        // =============================
        // LIST
        // =============================
        public async Task<List<RepackingIssueListDto>> GetListAsync(Guid branchId)
        {
            return await _http.GetFromJsonAsync<List<RepackingIssueListDto>>(
                $"api/repacking-issues?branchId={branchId}") ?? new();
        }


        // =============================
        // GET BY ID
        // =============================
        public async Task<RepackingIssueSaveDto> GetAsync(Guid id)
        {
            return await _http.GetFromJsonAsync<RepackingIssueSaveDto>(
                $"api/repacking-issues/{id}") ?? new();
        }


        // =============================
        // CREATE
        // =============================
        public async Task<HttpResponseMessage> CreateAsync(RepackingIssueSaveDto dto)
        {
            var res = await _http.PostAsJsonAsync("api/repacking-issues", dto);
            return res;            
        }


        // =============================
        // UPDATE
        // =============================
        public async Task<HttpResponseMessage> UpdateAsync(Guid id, RepackingIssueSaveDto dto)
        {
            var res = await _http.PutAsJsonAsync($"api/repacking-issues/{id}", dto);

            return res;
        }

        // =============================
        // DELETE
        // =============================
        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {
            var res = await _http.DeleteAsync($"api/repacking-issues/{id}");

            return res;
        }

    }
}
