using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{

    public interface IDashboardService
    {
        Task<DashboardKpiDto> GetKpisAsync();
        Task<List<SalesTrendDto>> GetSalesTrendAsync(int days);
        Task<List<PaymentBreakdownDto>> GetPaymentBreakdownAsync();
        Task<List<TopItemSalesDto>> GetTopItemsAsync();
        Task<List<LowStockDto>> GetLowStockItemsAsync();
    }
    public class DashboardApiService : BaseApiService,IDashboardService
    {
        
        public DashboardApiService(HttpClient http) : base(http) { }
       
        public async Task<DashboardKpiDto> GetKpisAsync()
            => await _http.GetFromJsonAsync<DashboardKpiDto>("api/dashboard/kpis") ?? new();

        public async Task<List<SalesTrendDto>> GetSalesTrendAsync(int days)
            => await _http.GetFromJsonAsync<List<SalesTrendDto>>(
                $"api/dashboard/sales-trend?days={days}") ?? new();

        public async Task<List<PaymentBreakdownDto>> GetPaymentBreakdownAsync()
            => await _http.GetFromJsonAsync<List<PaymentBreakdownDto>>(
                "api/dashboard/payment-breakdown") ?? new();

        public async Task<List<TopItemSalesDto>> GetTopItemsAsync()
            => await _http.GetFromJsonAsync<List<TopItemSalesDto>>(
                "api/dashboard/top-items") ?? new();

        public async Task<List<LowStockDto>> GetLowStockItemsAsync()
            => await _http.GetFromJsonAsync<List<LowStockDto>>(
                "api/dashboard/low-stock") ?? new();
    }

}
