using GameBloc.Models.Entity;
using GameBloc.Models.Setvices.Game;
using GameBloc.Models.Setvices.Game.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAddGameService, AddGameService>();
builder.Services.AddTransient<IAllGame, AllGame>();
var app = builder.Build();

app.MapControllerRoute(
    name: "Start Page",
    pattern: "{controller=Time}/{action=index}");

app.Run();
