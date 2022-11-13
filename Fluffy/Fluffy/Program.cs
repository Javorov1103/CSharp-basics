using Fluffy.Contracts;
using Fluffy.Data;
using Fluffy.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FluffyDbContext>(options =>
{
    options.UseSqlServer(@"Server=DESKTOP-OSKT1GA\SQLEXPRESS;Database=Fluffy;Trusted_Connection=True;TrustServerCertificate=True");
});
builder.Services.AddTransient<ICatService,CatService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cat}/{action=Index}/{id?}");

app.Run();
