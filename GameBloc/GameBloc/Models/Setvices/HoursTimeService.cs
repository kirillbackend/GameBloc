using GameBloc.Models.Setvices.Interface;

namespace GameBloc.Models.Setvices
{
    public class HoursTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.Hour.ToString();
    }
}
