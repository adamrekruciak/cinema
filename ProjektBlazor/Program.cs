using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProjektBlazor;
using ProjektBlazor.Services;
using ProjektBlazor.Services.Contracts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7212/") });
builder.Services.AddScoped<IMiejsceService, MiejsceService>();
builder.Services.AddScoped<IFilmService, FilmService>();


await builder.Build().RunAsync();
