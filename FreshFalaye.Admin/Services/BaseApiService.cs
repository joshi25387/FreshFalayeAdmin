using System.Net.Http.Json;

namespace FreshFalaye.Admin.Services
{
    public abstract class BaseApiService
    {
        protected readonly HttpClient _http;
        protected readonly AdminAuthService _auth;

        protected BaseApiService(HttpClient http)
        {
            _http = http ?? throw new Exception("HttpClient was not injected by DI");
        }
        //protected BaseApiService(IHttpClientFactory factory)
        //{
        //    _http = factory.CreateClient("Api");
        //}

        protected async Task<T> ReadResponse<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<T>();

            var error = await response.Content.ReadAsStringAsync();

            throw new ApiException(
                string.IsNullOrWhiteSpace(error) ? "Server error occurred" : error,
                (int)response.StatusCode);
        }

        protected async Task EnsureSuccess(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new ApiException(
                    string.IsNullOrWhiteSpace(error) ? "Server error occurred" : error,
                    (int)response.StatusCode);
            }
        }
    }
}
