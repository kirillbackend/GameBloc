using GameBloc.Models.CRUDOperations;
using GameBloc.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameBloc.Controllers
{
    public class AllGamesController : Controller
    {
        [HttpGet]
        public IActionResult AllGames(Reading reading) => View();

        [HttpPost]
        public IActionResult AllGames(int id)
        {
            var removal = new Removal(id);
            removal.PerformOperation();
            return View();
        }


        [HttpGet]
        public IActionResult AddGame() => View();

        [HttpPost]
        public void AddGame(string name, string genre, string stylistics
            , string yearRelease, string author, string feelings)
        {
            var game = new Game()
            {
                Name = name,
                Genre = genre,
                Stylistics = stylistics,
                YearRelease = yearRelease,
                Author = author,
                Feelings = feelings
            };
            var add = new Addendum(game);
            add.PerformOperation();
        }
    }
}
