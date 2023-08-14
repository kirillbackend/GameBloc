using GameBloc.Models.Setvices.Interface;
using System.Text;

namespace GameBloc.Models.Setvices
{
    public class Date : IDate
    {
        private readonly int _day;
        private readonly int _month;
        private readonly int _year;

        public Date(int day, int month, int year) 
        {
            _day = day;
            _month = month + 1;
            _year = year;
        }

        public DateTime GetDate()
        {
            var builder = new StringBuilder();
            builder.Append(_year);
            builder.Append("-");
            builder.Append(_month);
            builder.Append("-");
            builder.Append(_day);
            var myDate = DateTime.Parse(builder.ToString());
            return myDate;
        }
    }
}
