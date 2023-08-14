using GameBloc.Models.Setvices.Interface;

namespace GameBloc.Models.Setvices
{
    public class MinutesTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.Minute.ToString();
    }
}
