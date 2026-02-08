using FreshFalaye.Admin.Models;
using System.Net.Http.Json;

namespace FreshFalaye.Admin.Services
{
    public class StockReportApiService : BaseApiService
    {
        public StockReportApiService(HttpClient http) : base(http) { }

        // Optional: JSON summary data (if still needed)
        public async Task<List<StockSummaryDto>> GetSummaryAsync(
            StockSummaryRequest request)
        {
            var response = await _http.PostAsJsonAsync(
                "api/reports/stock/summary",
                request);

            response.EnsureSuccessStatusCode();

            return await response.Content
                .ReadFromJsonAsync<List<StockSummaryDto>>()
                ?? new List<StockSummaryDto>();
        }

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
    }
}
