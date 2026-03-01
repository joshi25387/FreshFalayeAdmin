using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class LedgerReportApiService : BaseApiService
    {
        public LedgerReportApiService(HttpClient http) : base(http) { }

        public async Task<byte[]> GetLedgerReportAsync(
           LedgerReportRequestDto request)
        {
            var response = await _http.PostAsJsonAsync(
                "api/reports/ledger/ledger-report",
                request);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsByteArrayAsync();
        }

        public async Task<List<LedgerReportDto>> GetLedgerGridAsync(
           LedgerReportRequestDto request)
        {
            var response = await _http.PostAsJsonAsync(
                "api/reports/ledger/ledger-report-data",
                request);

            return await ReadResponse<List<LedgerReportDto>>(response);            
        }
    }
}
