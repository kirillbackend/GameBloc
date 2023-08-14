using GameBloc.Models.Setvices;
using GameBloc.Models.Setvices.Interface;

namespace GameBloc.Models
{
    public class TimeModel : ITimeService
    {
        private readonly string _timeType;
        private readonly Dictionary<string, Func<ITimeService>> _timeMetods;

        public TimeModel(string timeType)
        {
            _timeType = timeType;

            _timeMetods = new Dictionary<string, Func<ITimeService>>()
            {
                {"long", () => new LongTimeService()},
                {"short", () => new ShortTimeService()},
                {"hours", () => new HoursTimeService()},
                {"minutes", () => new  MinutesTimeService()}
            };
        }

        public string GetTime()
        {
            var time = _timeMetods[_timeType]();
            return time.GetTime();
        }
    }
}
