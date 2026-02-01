using FreshFalaye.Admin.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FreshFalaye.Admin.Services
{
    public class VoucherApiService : BaseApiService
    {
        public VoucherApiService(HttpClient http) : base(http) { }


        public async Task<List<BankVoucherModeDto>> GetBankVoucherModes()
        {
            return await _http.GetFromJsonAsync<List<BankVoucherModeDto>>($"api/bank-voucher-modes");
        }
        public async Task<List<VoucherTypeDto>> GetVoucherTypes()
        {
            return await _http.GetFromJsonAsync<List<VoucherTypeDto>>($"api/voucher-types");
        }

        public async Task<List<VoucherDto>> GetVouchersAsync(string voucherType)
        {
            try
            {
                return await _http.GetFromJsonAsync<List<VoucherDto>>($"api/vouchers/voucher-type/{voucherType}");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<VoucherDto> GetVoucherAsync(Guid id)
        {
            return await _http.GetFromJsonAsync<VoucherDto>($"api/vouchers/{id}");
        }

        public async Task<HttpResponseMessage> CreateAsync(VoucherDto dto)
        {
            try
            {
                //string json = JsonConvert.SerializeObject(dto);
                var response = await _http.PostAsJsonAsync("api/vouchers", dto);
                return response;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public async Task<HttpResponseMessage> UpdateAsync(VoucherDto dto)
        {
            return await _http.PutAsJsonAsync($"api/vouchers", dto);
        }

        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {
            return await _http.DeleteAsync($"api/vouchers/{id}");
        }
    }
}
