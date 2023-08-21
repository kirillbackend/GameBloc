using GameBloc.Models.CalculatorModel.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GameBloc.Controllers
{
    public class CalculatorController : Controller
    {
        private ICalculatorModel _calculatorModel;

        public CalculatorController(ICalculatorModel calculatorModel) 
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
            _calculatorModel.Simbol = simbol;
            _calculatorModel.FirstValue = firstValue;
            _calculatorModel.SecondValue = secondValue; 
            return View(_calculatorModel.Calculate());
        }
    }
}
