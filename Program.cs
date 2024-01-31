using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp;
using Blazored.LocalStorage;
using BlazorApp.Services;
using BlazorApp.StateContainers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddSingleton<DemoStateContainer>();

builder.Services.AddScoped<IDummyDataService, DummyDataService>();
builder.Services.AddScoped<ITodoDataService, TodoDataService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


await builder.Build().RunAsync();
