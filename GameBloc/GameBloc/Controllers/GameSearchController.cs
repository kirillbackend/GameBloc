using GameBloc.Models.Setvices.Game;
using Microsoft.AspNetCore.Mvc;

namespace GameBloc.Controllers
{
    public class GameSearchController : Controller
    {
        [HttpGet]
        public IActionResult ShowGame(int id) => View(id);

        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(int id)
        {
            return RedirectPermanent("~/GameSearch/ShowGame");
        }
    }
}
