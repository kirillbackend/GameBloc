using GameBloc.Models.CalculatorModel.Interface;

namespace GameBloc.Models.CalculatorModel
{
    public class CalculatorModel : ICalculator
    {
        private readonly Dictionary<string, Func<int,int,int>> _metods;

        public CalculatorModel()
        {
            _metods = new Dictionary<string, Func<int, int, int>> 
            {
                {"+", (a,b) => a + b },
                {"-", (a,b) => a - b },
                {"*", (a,b) => a * b },
                {"/", (a,b) => a / b }
            };
        }

        public int Calculate(string _simbol, int _firstValue, int _secondValue)
        {
            return _metods[_simbol](_firstValue, _secondValue);
        }
    }
}
