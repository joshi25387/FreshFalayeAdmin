using Blazored.LocalStorage;
using FreshFalaye.Admin.Components;
using FreshFalaye.Admin.Models;
using FreshFalaye.Admin.Services;
using Microsoft.Extensions.Options;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.Configure<ApiSettings>(
    builder.Configuration.GetSection("ApiSettings"));

builder.Services.AddSingleton(sp =>
    sp.GetRequiredService<IOptions<ApiSettings>>().Value);

builder.Services.AddBlazoredLocalStorage();

//builder.Services.AddHttpClient();
//builder.Services.AddHttpClient("Api", (sp, client) =>
//{
//    var settings = sp.GetRequiredService<ApiSettings>();
//    client.BaseAddress = new Uri(settings.BaseUrl);
//    client.Timeout = TimeSpan.FromSeconds(30);
//});

builder.Services.AddScoped(sp =>
{
    var settings = sp.GetRequiredService<ApiSettings>();

    if (string.IsNullOrWhiteSpace(settings.BaseUrl))
        throw new InvalidOperationException("ApiSettings:BaseUrl is not configured");

    return new HttpClient
    {
        BaseAddress = new Uri(settings.BaseUrl),
        Timeout = TimeSpan.FromSeconds(30)
    };
});


//builder.Services.AddHttpClient<ProductApiService>((sp, client) =>
//{
//    var settings = sp.GetRequiredService<ApiSettings>();
//    client.BaseAddress = new Uri(settings.BaseUrl);
//});

//builder.Services.AddHttpClient<UnitApiService>((sp, client) =>
//{
//    var settings = sp.GetRequiredService<ApiSettings>();
//    client.BaseAddress = new Uri(settings.BaseUrl);
//});
//builder.Services.AddHttpClient<AdminApiService>((sp, client) =>
//{
//    var settings = sp.GetRequiredService<ApiSettings>();
//    client.BaseAddress = new Uri(settings.BaseUrl);
//});
//builder.Services.AddHttpClient<AdminAuthService>((sp, client) =>
//{
//    var settings = sp.GetRequiredService<ApiSettings>();
//    client.BaseAddress = new Uri(settings.BaseUrl);
//});
//builder.Services.AddHttpClient<ProductGroupApiService>((sp, client) =>
//{
//    var settings = sp.GetRequiredService<ApiSettings>();
//    client.BaseAddress = new Uri(settings.BaseUrl);
//});
//builder.Services.AddHttpClient<PartyApiService>((sp, client) =>
//{
//    var settings = sp.GetRequiredService<ApiSettings>();
//    client.BaseAddress = new Uri(settings.BaseUrl);
//});
//builder.Services.AddHttpClient<ExpenseMasterApiService>((sp, client) =>
//{
//    var settings = sp.GetRequiredService<ApiSettings>();
//    client.BaseAddress = new Uri(settings.BaseUrl);
//});
//builder.Services.AddHttpClient<PurchaseApiService>((sp, client) =>
//{
//    var settings = sp.GetRequiredService<ApiSettings>();
//    client.BaseAddress = new Uri(settings.BaseUrl);
//});


builder.Services.AddRadzenComponents();

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();

builder.Services.AddScoped<AdminApiService>();
builder.Services.AddScoped<AdminAuthService>();
builder.Services.AddScoped<UnitApiService>();
builder.Services.AddScoped<ProductGroupApiService>();
builder.Services.AddScoped<ProductApiService>();
builder.Services.AddScoped<AccountApiService>();
builder.Services.AddScoped<AccountGroupApiService>();
builder.Services.AddScoped<ExpenseMasterApiService>();
builder.Services.AddScoped<PurchaseApiService>();
builder.Services.AddScoped<VoucherApiService>();
builder.Services.AddScoped<RepackingIssueApiService>();
builder.Services.AddScoped<StockApiService>();
builder.Services.AddScoped<IDashboardService, DashboardApiService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
