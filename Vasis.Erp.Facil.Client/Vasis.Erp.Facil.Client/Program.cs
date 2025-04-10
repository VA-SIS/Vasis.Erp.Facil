using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Vasis.Erp.Facil.Client;
using Vasis.Erp.Facil.Client.Services;
using MudBlazor.Services;
using Vasis.Erp.Facil.Server.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configura o HttpClient
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Registra os serviços da aplicação
builder.Services.AddScoped<EmpresaService>();
//builder.Services.AddScoped<PessoaService>();

// Adiciona MudBlazor
builder.Services.AddMudServices();

await builder.Build().RunAsync();
