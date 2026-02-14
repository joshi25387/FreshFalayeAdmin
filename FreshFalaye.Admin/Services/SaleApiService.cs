using FreshFalaye.Admin.Models;

namespace FreshFalaye.Admin.Services
{
    public class SaleApiService : BaseApiService
    {
        public SaleApiService(HttpClient http) : base(http) { }

        // ===============================
        // SAVE PURCHASE VOUCHER
        // ===============================
        public async Task<HttpResponseMessage> CreateAsync(SaleSaveDto dto)
        {
            var response = await _http.PostAsJsonAsync("api/sales/upload-admin", dto);
            return response;
            //await EnsureSuccess(response);
        }

        // ===============================
        // UDPATE PURCHASE VOUCHER
        // ===============================
        public async Task<HttpResponseMessage> UpdateAsync(SaleSaveDto dto)
        {
            var response = await _http.PutAsJsonAsync("api/sales/edit", dto);
            return response;
            //await EnsureSuccess(response);
        }

        // ===============================
        // GET PURCHASE BY ID (Future Edit)
        // ===============================
        public async Task<SaleGetDto> GetAsync(Guid id)
        {
            try
            {
                var response = await _http.GetAsync($"api/sales/by-id/{id}");
                return await ReadResponse<SaleGetDto>(response);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        // ===============================
        // LIST PURCHASES (Future Grid)
        // ===============================
        public async Task<List<SaleListDto>> GetListAsync()
        {
            var response = await _http.GetAsync("api/sales/sale-list");
            return await ReadResponse<List<SaleListDto>>(response);
        }
    }
}
