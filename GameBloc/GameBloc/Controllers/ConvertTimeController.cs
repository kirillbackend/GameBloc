using GameBloc.Models.Setvices.ConvertTime;
using GameBloc.Models.Setvices.ConvertTime.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GameBloc.Controllers
{
    public class ConvertTimeController : Controller
    {
        private IConvertTimeService _convertTimeService;

        public ConvertTimeController(IConvertTimeService convertTimeService) 
        {
            _convertTimeService = convertTimeService;
        }

        [HttpGet]
        public IActionResult Index(int r)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int number, TimePart fromTimePart, TimePart toTimePart)
        {
            return View(_convertTimeService.GetTime(number, fromTimePart, toTimePart));
        }
    }
}
