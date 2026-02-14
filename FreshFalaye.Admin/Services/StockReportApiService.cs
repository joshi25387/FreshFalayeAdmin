using FreshFalaye.Admin.Models;
using System.Net.Http.Json;

namespace FreshFalaye.Admin.Services
{
    public class StockReportApiService : BaseApiService
    {
        public StockReportApiService(HttpClient http) : base(http) { }


        // PDF version
        public async Task<byte[]> GetSummaryPdfAsync(
            StockSummaryRequest request)
        {
            var response = await _http.PostAsJsonAsync(
                "api/reports/stock/summary-pdf",
                request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }

        public async Task<byte[]> GetDetailPdfAsync(
            StockSummaryRequest request)
        {
            var response = await _http.PostAsJsonAsync(
                "api/reports/stock/detail-pdf",
                request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
