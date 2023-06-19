using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using UnitedSystemsCooperative.Web.Client;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddConfigs(builder.Configuration);
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddServices(builder.Configuration);
builder.Services.AddMudServices();

await builder.Build().RunAsync();

[ExcludeFromCodeCoverage]
// ReSharper disable once UnusedType.Global
public partial class Program { }