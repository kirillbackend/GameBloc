using GameBloc.Models.CalculatorModel.Interface;

namespace GameBloc.Models.CalculatorModel
{
    public class CalculatorModel : ICalculatorModel
    {
        private int _firstValue;
        private int _secondValue;
        private string _simbol;
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

        public int FirstValue { set { _firstValue = value; } }

        public int SecondValue { set { _secondValue = value; } }

        public string Simbol { set { _simbol = value; } }

        public int Calculate()
        {
            return _metods[_simbol](_firstValue, _secondValue);
        }
    }
}
