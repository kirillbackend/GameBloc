namespace GameBloc.Models.CalculatorModel.Interface
{
    public interface ICalculatorModel
    {
        public int FirstValue { set; }
        public int SecondValue { set; }
        public string Simbol { set; }
        public int Calculate();
    }
}