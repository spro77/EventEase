using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Register your services
builder.Services.AddSingleton<EventService>();
builder.Services.AddSingleton<EventEase.Services.SessionService>();

await builder.Build().RunAsync();