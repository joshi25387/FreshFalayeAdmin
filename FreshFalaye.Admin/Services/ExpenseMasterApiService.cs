using FreshFalaye.Admin.Models;
using System.Net.Http.Json;

namespace FreshFalaye.Admin.Services
{
    public class ExpenseMasterApiService :  BaseApiService
    {
        //private readonly HttpClient _http;

        public ExpenseMasterApiService(HttpClient http) : base(http) { }
        //public ExpenseMasterApiService(IHttpClientFactory factory)
        //{
        //    _http = factory.CreateClient("Api");
        //}

        public async Task<List<ExpenseMasterDto>> GetAllAsync()
        {
            return await _http.GetFromJsonAsync<List<ExpenseMasterDto>>("api/expense-master");
        }

        public async Task<HttpResponseMessage> SaveAsync(ExpenseMasterDto dto)
        {
            return await _http.PostAsJsonAsync("api/expense-master", dto);            
        }
        public async Task<HttpResponseMessage> DeleteAsync(Guid id)
        {
            return await _http.DeleteAsync($"api/expense-master/{id}");            
        }
        public async Task<List<PurchaseExpenseDto>> GetPurchaseExpensesAsync()
        {
            var response = await _http.GetAsync("api/expense-master");

            var all = await ReadResponse<List<ExpenseMasterDto>>(response);

            return all.Where(x => x.ExpenseType == "Purchase")
                .OrderBy(x => x.ExpenseName).Select(x=> new PurchaseExpenseDto
            { 
                ExpenseMasterId = x.Id,
                Expense = x.ExpenseName,
                RateType = x.RateType,
                Bearer = x.Bearer,
                Rate = x.Rate                
            }).ToList();
        }

    }
}
