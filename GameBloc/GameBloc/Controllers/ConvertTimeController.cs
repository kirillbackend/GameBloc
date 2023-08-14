using GameBloc.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameBloc.Controllers
{
    public class ConvertTimeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int number,string initialValue, string finalValue)
        {
            var metod = initialValue + finalValue;
            var convert = new ConvertTimeModel(number, metod);
            ViewData["result"] = convert.GetTime();
            return View();
        }
    }
}
