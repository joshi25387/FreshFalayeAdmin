namespace FreshFalaye.Admin.Services
{
    public class AdminApiService : BaseApiService
    {
        //private readonly HttpClient _http;

        public AdminApiService(HttpClient http) : base(http) { }
        //public AdminApiService(IHttpClientFactory factory)
        //{
        //    _http = factory.CreateClient("Api");
        //}

        // test call
        public async Task<bool> PingAsync()
        {
            try
            {
                var res = await _http.GetAsync("/api/health");
                return res.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}
