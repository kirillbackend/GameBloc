namespace GameBloc.Models.Setvices.ConvertTime.Interface
{
    public interface IConvertTimeService
    {
        public double GetTime(int value, TimePart fromTimePart, TimePart toTimePart);
    }
}