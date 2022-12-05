using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MTG_Card_Collection_App.Data;
using MTG_Card_Collection_App.Models;

var builder = WebApplication.CreateBuilder(args);

// MUST BE CALLED before AddControllersWithViews
builder.Services.AddMemoryCache();
builder.Services.AddSession();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CardContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CardContext")));

builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
})
    .AddEntityFrameworkStores<CardContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapAreaControllerRoute(
        name: "admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Static",
    pattern: "{controller=Home}/{action}/Page/{num}");

app.MapControllerRoute(
    name: "search",
    pattern: "{controller=Home}/{action=Search}/{NameFilter?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

await CardContext.CreateAdminUser(app.Services);

app.Run();
