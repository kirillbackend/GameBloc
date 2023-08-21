using GameBloc.Models.CalculatorModel;
using GameBloc.Models.CalculatorModel.Interface;
using GameBloc.Models.Entity;
using GameBloc.Models.Setvices.ConvertTime;
using GameBloc.Models.Setvices.ConvertTime.Interface;
using GameBloc.Models.Setvices.OperationsGames;
using GameBloc.Models.Setvices.OperationsGames.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IConvertTimeService, ConvertTimeService>();

builder.Services.AddTransient<IAddGameService, AddGameService>();
builder.Services.AddTransient<IAllGame, AllGame>();
builder.Services.AddTransient<ICalculator, CalculatorModel>();

var app = builder.Build();


app.MapControllerRoute(
    name: "Start Page",
    pattern: "{controller=Time}/{action=index}");

app.Run();
