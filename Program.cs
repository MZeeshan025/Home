using Microsoft.EntityFrameworkCore;
using Zeeshan_Proj.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DBContextModel>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=Home}/{id?}"
    );   

app.Run();
