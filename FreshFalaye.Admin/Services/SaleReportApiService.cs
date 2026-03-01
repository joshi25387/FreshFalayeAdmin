using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class SaleReportApiService : BaseApiService
    {
        public SaleReportApiService(HttpClient http) : base(http) { }


        // PDF version
        public async Task<byte[]> GetSummaryPdfAsync(
            SaleSummaryRequest request)
        {
            var response = await _http.PostAsJsonAsync(
                "api/reports/sale/summary",
                request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }

        public async Task<byte[]> GetDetailPdfAsync(
            SaleSummaryRequest request)
        {
            var response = await _http.PostAsJsonAsync(
                "api/reports/sale/detail",
                request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
