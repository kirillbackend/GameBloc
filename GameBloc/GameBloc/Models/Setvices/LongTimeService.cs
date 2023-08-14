using GameBloc.Models.Setvices.Interface;

namespace GameBloc.Models.Setvices
{
    public class LongTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToLongTimeString();
    }
}
