using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class StockApiService : BaseApiService
    {
        public StockApiService(HttpClient http) : base(http) { }

        // =============================
        // GET batch stock
        // =============================
        public async Task<List<BranchBatchStockDto>> GetBatchStockAsync(Guid branchId)
        {
            return await _http.GetFromJsonAsync<List<BranchBatchStockDto>>(
                $"api/stock/batches/{branchId}") ?? new();
        }
    }
}
