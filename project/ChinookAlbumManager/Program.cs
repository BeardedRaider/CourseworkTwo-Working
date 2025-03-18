using ChinookAlbumManager;
using ChinookAlbumManager.Data;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");  // ✅ Ensure App component is added

// Register SQLite Database Context
builder.Services.AddDbContextFactory<ChinookDbContext>(options =>
    options.UseSqlite("Data Source=C:/Users/gamer/Desktop/CourseworkTwo-Working/chinook.db"));

await builder.Build().RunAsync();
