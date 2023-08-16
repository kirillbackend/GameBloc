using GameBloc.Models.Entity;
using GameBloc.Models.Setvices.Game.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GameBloc.Controllers
{
    public class AddGameController : Controller
    {
        [HttpGet]
        public IActionResult AllGame() => View();

        [HttpGet]
        public IActionResult AddGame(int e)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGame()
        {
            var context = Request.HttpContext;
            var game = new Game();
            game.Name = context.Request.Form["name"];
            game.Genre = context.Request.Form["genre"];
            game.Stylistics = context.Request.Form["stylistics"];
            game.YearRelease = context.Request.Form["yearRelease"];
            game.Author = context.Request.Form["author"];
            game.Feelings = context.Request.Form["feelings"];
            var service = context.RequestServices.GetService<IAddGameService>();
            service.AddGame(game);
            return RedirectPermanent("~/AddGame/AllGame");
        }
    }
}
