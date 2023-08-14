var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
    name: "Start Page",
    pattern: "{controller=Time}/{action=index}");

app.Run();
