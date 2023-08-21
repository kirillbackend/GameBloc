using GameBloc.Models;
using GameBloc.Models.Setvices.ConvertTime.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GameBloc.Controllers
{
    public class ConvertTimeController : Controller
    {
        private IConvertTimeModel _convertTimeModel;

        public ConvertTimeController(IConvertTimeModel convertTimeModel) 
        {
            _convertTimeModel = convertTimeModel;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int number,string initialValue, string finalValue)
        {
            var metod = initialValue + finalValue;
            _convertTimeModel.Metod = metod;
            _convertTimeModel.Value = number;
            return View(_convertTimeModel.GetTime());
        }
    }
}
