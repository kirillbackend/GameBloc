using GameBloc.Models.Entity;
using GameBloc.Models.Setvices.OperationsGames.Interface;
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
        public IActionResult AddGame(Game game)
        {
            var context = Request.HttpContext;
            var service = context.RequestServices.GetService<IAddGameService>();
            service.AddGame(game);
            return RedirectPermanent("~/AddGame/AllGame");
        }
    }
}
