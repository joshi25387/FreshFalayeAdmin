using Blazored.LocalStorage;
using FreshFalaye.Admin.Models;
using System.Net.Http.Headers;

namespace FreshFalaye.Admin.Services
{
    public class AdminAuthService : BaseApiService
    {
        //private readonly HttpClient _http;
        private readonly ILocalStorageService _localStorage;

        private const string StorageKey = "admin_user";

        public AdminUser? CurrentUser { get; private set; }
        public bool IsInitialized { get; private set; }

        // 🔔 STATE CHANGE EVENT
        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();

        public AdminAuthService(HttpClient http, ILocalStorageService localStorage) : base(http) 
        {
            _localStorage = localStorage;
        }
        //public AdminAuthService(
        //    IHttpClientFactory factory,
        //    ILocalStorageService localStorage)
        //{
        //    _http = factory.CreateClient("Api");
        //    _localStorage = localStorage;
        //}

        // 🔑 Call this once on app startup
        public async Task InitializeAsync()
        {
            if (IsInitialized)
                return;
            CurrentUser = await _localStorage.GetItemAsync<AdminUser>(StorageKey);

            if (CurrentUser != null && !string.IsNullOrEmpty(CurrentUser.Token))
            {
                _http.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", CurrentUser.Token);
            }

            IsInitialized = true;
            NotifyStateChanged();
        }
        
        public async Task<bool> LoginAsync(string username, string password)
        {
            try
            {
                var res = await _http.PostAsJsonAsync(
                    "/api/admin/auth/login",
                    new { Username = username, Password = password });

                if (!res.IsSuccessStatusCode)
                    return false;

                CurrentUser = await res.Content.ReadFromJsonAsync<AdminUser>();

                _http.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", CurrentUser.Token);


                await _localStorage.SetItemAsync(StorageKey, CurrentUser);

                IsInitialized = true;          // 🔥 THIS WAS MISSING

                NotifyStateChanged();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task LogoutAsync()
        {
            CurrentUser = null;
            IsInitialized = true;              // 🔥 keep initialized

            _http.DefaultRequestHeaders.Authorization = null;

            await _localStorage.RemoveItemAsync(StorageKey);
            NotifyStateChanged();
        }
    }
}
