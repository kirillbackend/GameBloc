using GameBloc.Models.CalculatorModel.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GameBloc.Controllers
{
    public class CalculatorController : Controller
    {
        private ICalculator _calculatorModel;

        public CalculatorController(ICalculator calculatorModel) 
        {
            _calculatorModel = calculatorModel;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int firstValue, int secondValue, string simbol)
        {
            return View(_calculatorModel.Calculate(simbol, firstValue, secondValue));
        }
    }
}
