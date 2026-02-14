using FreshFalaye.Admin.Models;
using System.Net.Http.Json;

namespace FreshFalaye.Admin.Services
{
    public class PurchaseApiService : BaseApiService
    {
        public PurchaseApiService(HttpClient http) : base(http) { }

        // ===============================
        // SAVE PURCHASE VOUCHER
        // ===============================
        public async Task<HttpResponseMessage> CreateAsync(PurchaseSaveDto dto)
        {
            var response = await _http.PostAsJsonAsync("api/purchases", dto);
            return response;
            //await EnsureSuccess(response);
        }

        // ===============================
        // UDPATE PURCHASE VOUCHER
        // ===============================
        public async Task<HttpResponseMessage> UpdateAsync(PurchaseSaveDto dto)
        {
            var response = await _http.PutAsJsonAsync("api/purchases", dto);
            return response;
            //await EnsureSuccess(response);
        }

        // ===============================
        // GET PURCHASE BY ID (Future Edit)
        // ===============================
        public async Task<PurchaseGetDto> GetAsync(Guid id)
        {
            var response = await _http.GetAsync($"api/purchases/{id}");
            return await ReadResponse<PurchaseGetDto>(response);
        }

        // ===============================
        // LIST PURCHASES (Future Grid)
        // ===============================
        public async Task<List<PurchaseListDto>> GetListAsync()
        {
            var response = await _http.GetAsync("api/purchases");
            return await ReadResponse<List<PurchaseListDto>>(response);
        }
    }
}
