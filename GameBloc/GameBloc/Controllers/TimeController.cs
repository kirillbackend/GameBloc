using GameBloc.Models;
using GameBloc.Models.Setvices;
using Microsoft.AspNetCore.Mvc;

namespace GameBloc.Controllers
{
    public class TimeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            var context = ControllerContext.HttpContext;
            int firstDay = Convert.ToInt32(context.Request.Form["firstDay"]);
            int firstMonth = Convert.ToInt32(context.Request.Form["firstMonth"]);
            int firstYear = Convert.ToInt32(context.Request.Form["firstYear"]);
            int secondDay = Convert.ToInt32(context.Request.Form["secondDay"]);
            int secondMonth = Convert.ToInt32(context.Request.Form["secondMonth"]);
            int secondYear = Convert.ToInt32(context.Request.Form["secondYear"]);
            var date = new Date(firstDay, firstMonth, firstYear);
            var firstDate = date.GetDate();
            date = new Date(secondDay, secondMonth, secondYear);
            var secondDate = date.GetDate();
            ViewData["Time"] = firstDate.Subtract(secondDate).Days;
            return View();
        }
    }
}
