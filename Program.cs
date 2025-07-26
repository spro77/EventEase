using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EventEase;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Register your TaskService
builder.Services.AddSingleton<TaskService>();

await builder.Build().RunAsync();