using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class RepackingReceiveApiService : BaseApiService
    {
        public RepackingReceiveApiService(HttpClient http) : base(http) { }


        public async Task<List<RepackingReceiveListDto>> GetListAsync(Guid branchId)
        {
            return await _http.GetFromJsonAsync<List<RepackingReceiveListDto>>
                ($"api/repacking-receives?branchId={branchId}");
        }

        // =============================
        // GET BY ID
        // =============================
        public async Task<RepackingReceiveSaveDto> GetAsync(Guid id)
        {
            return await _http.GetFromJsonAsync<RepackingReceiveSaveDto>(
                $"api/repacking-receives/{id}") ?? new();
        }

        public async Task<List<PendingIssueDto>> GetPendingIssuesAsync(Guid branchId, Guid? excludeReceiveId = null)
        {            
            var url = $"api/repacking-receives/pending-issues?branchId={branchId}";

            if (excludeReceiveId.HasValue)
                url += $"&excludeReceiveId={excludeReceiveId}";

            return await _http.GetFromJsonAsync<List<PendingIssueDto>>(url);
        }

        
        // =============================
        // CREATE
        // =============================
        public async Task<HttpResponseMessage> CreateAsync(RepackingReceiveSaveDto dto)
        {
            var res = await _http.PostAsJsonAsync("api/repacking-receives", dto);
            return res;            
        }


        // =============================
        // UPDATE
        // =============================
        public async Task<HttpResponseMessage> UpdateAsync(Guid id, RepackingReceiveSaveDto dto)
        {
            var res = await _http.PutAsJsonAsync($"api/repacking-receives/{id}", dto);

            return res;
        }

        // =============================
        // DELETE
        // =============================
        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {
            var res = await _http.DeleteAsync($"api/repacking-receives/{id}");

            return res;
        }

    }
}
