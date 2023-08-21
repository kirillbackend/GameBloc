namespace GameBloc.Models.Setvices.ConvertTime.Interface
{
    public interface IConvertTimeModel
    {
        public int Value { set; }
        public string Metod { set; }
        public double GetTime();
    }
}
