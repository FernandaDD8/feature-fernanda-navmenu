using MudBlazor.Services;
using DD8_Blazor.Components;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);


// 🔹 Configurando Kestrel para usar as portas 5000 e 5001
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5000); // HTTP
    options.ListenAnyIP(5001, listenOptions =>
    {
        listenOptions.UseHttps(); // HTTPS
    });
});

// Configuração de Cookies: SameSite=None e Secure sempre habilitado
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.MinimumSameSitePolicy = SameSiteMode.None;
    options.Secure = CookieSecurePolicy.Always; // Garante que cookies só serão enviados via HTTPS
});

// Adiciona MudBlazor services
builder.Services.AddMudServices();

// Adiciona serviços ao container
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configuração do pipeline HTTP
// Redireciona HTTP para HTTPS
app.UseHttpsRedirection();

// Aplica a política de cookies
app.UseCookiePolicy();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
