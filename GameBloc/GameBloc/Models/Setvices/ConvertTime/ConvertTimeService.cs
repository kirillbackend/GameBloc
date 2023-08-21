using GameBloc.Models.Setvices.ConvertTime.Interface;

namespace GameBloc.Models.Setvices.ConvertTime
{
    public class ConvertTimeService : IConvertTimeService
    {
        private TimeSpan CreateTimespan(int value, TimePart timePart)
        {
            return timePart switch
            {
                TimePart.Hour => TimeSpan.FromHours(value),
                TimePart.Minute => TimeSpan.FromMinutes(value),
                TimePart.Second => TimeSpan.FromSeconds(value),
                TimePart.Millisecond => TimeSpan.FromMilliseconds(value),
                _ => throw new ArgumentOutOfRangeException(nameof(timePart), timePart, null)
            };
        }

        private double GetTotalPartByType(TimeSpan value, TimePart timePart)
        {
            return timePart switch
            {
                TimePart.Hour => value.TotalHours,
                TimePart.Minute => value.TotalMinutes,
                TimePart.Second => value.TotalSeconds,
                TimePart.Millisecond => value.TotalMilliseconds,
                _ => throw new ArgumentOutOfRangeException(nameof(timePart), timePart, null)
            };
        }

        public double GetTime(int value, TimePart fromTimePart, TimePart toTimePart)
        {
            var timeSpan = CreateTimespan(value, fromTimePart);
            var result = GetTotalPartByType(timeSpan, toTimePart);

            return result;
        }
    }
}
