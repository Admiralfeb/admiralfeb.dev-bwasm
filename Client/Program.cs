using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp.Client;
using Microsoft.Extensions.Configuration;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var http = new HttpClient()
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
};

builder.Services.AddScoped(sp => http);
builder.Services.AddSingleton<StateContainer>();



// using var response = await http.GetAsync("cars.json");
// using var stream = await response.Content.ReadAsStreamAsync();

// builder.Configuration.AddJsonStream(stream);

await builder.Build().RunAsync();
