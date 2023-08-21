using GameBloc.Models;
using GameBloc.Models.CalculatorModel;
using GameBloc.Models.CalculatorModel.Interface;
using GameBloc.Models.Entity;
using GameBloc.Models.Setvices.ConvertTime.Interface;
using GameBloc.Models.Setvices.Game;
using GameBloc.Models.Setvices.Game.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IAddGameService, AddGameService>();
builder.Services.AddTransient<IAllGame, AllGame>();
builder.Services.AddTransient<ICalculatorModel, CalculatorModel>();
builder.Services.AddTransient<IConvertTimeModel, ConvertTimeModel>();
var app = builder.Build();


app.MapControllerRoute(
    name: "Start Page",
    pattern: "{controller=Time}/{action=index}");

app.Run();
