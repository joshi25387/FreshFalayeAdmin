using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class PurchaseReportApiService : BaseApiService
    {
        public PurchaseReportApiService(HttpClient http) : base(http) { }


        // PDF version
        public async Task<byte[]> GetSummaryPdfAsync(
            PurchaseSummaryRequest request)
        {
            var response = await _http.PostAsJsonAsync(
                "api/reports/purchase/summary",
                request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }

        public async Task<byte[]> GetDetailPdfAsync(
            PurchaseSummaryRequest request)
        {
            var response = await _http.PostAsJsonAsync(
                "api/reports/purchase/detail",
                request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
