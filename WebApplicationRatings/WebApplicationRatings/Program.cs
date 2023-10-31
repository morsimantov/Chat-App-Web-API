using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationRatings.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebApplicationRatingsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplicationRatingsContext") ?? throw new InvalidOperationException("Connection string 'WebApplicationRatingsContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=RankingItems}/{action=Index}/{id?}");

app.Run();
