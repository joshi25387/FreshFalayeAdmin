using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class RepackingReceiveReportApiService : BaseApiService
    {
        public RepackingReceiveReportApiService(HttpClient http) : base(http) { }


        // PDF version
        public async Task<byte[]> GetSummaryPdfAsync(
            RepackingReceiveReportRequest request)
        {
            var response = await _http.PostAsJsonAsync(
                "api/reports/repacking-receive/summary",
                request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
