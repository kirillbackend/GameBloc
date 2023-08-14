using GameBloc.Models.Setvices.Interface;

namespace GameBloc.Models.Setvices
{
    public class ShortTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToShortTimeString();
    }
}
