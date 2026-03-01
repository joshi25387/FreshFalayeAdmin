using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class RepackingIssueReportApiService : BaseApiService
    {
        public RepackingIssueReportApiService(HttpClient http) : base(http) { }


        // PDF version
        public async Task<byte[]> GetSummaryPdfAsync(
            RepackingIssueReportRequest request)
        {
            var response = await _http.PostAsJsonAsync(
                "api/reports/repacking-issue/summary",
                request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
