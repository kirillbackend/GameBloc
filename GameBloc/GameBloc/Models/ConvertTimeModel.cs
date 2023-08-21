using GameBloc.Models.Setvices.ConvertTime.Interface;

namespace GameBloc.Models
{
    public class ConvertTimeModel : IConvertTimeModel
    {
        private int _value;
        private string _metod;
        private readonly Dictionary<string, Func<int, double>> convertMetols;

        public int Value { set { _value = value; } }
        public string Metod { set { _metod = value; } }

        public ConvertTimeModel()
        {
            convertMetols = new Dictionary<string, Func<int, double>>()
            {
                {"ЧасыЧасы", (value) =>  TimeSpan.FromHours(value).TotalHours},
                {"ЧасыМинуты", (value) =>  TimeSpan.FromHours(value).TotalMinutes},
                {"ЧасыСекунды", (value) =>  TimeSpan.FromHours(value).TotalSeconds},
                {"ЧасыМилисекунды", (value) =>  TimeSpan.FromHours(value).TotalMilliseconds},

                {"МинутыЧасы", (value) =>  TimeSpan.FromMinutes(value).TotalHours},
                {"МинутыМинуты", (value) =>  TimeSpan.FromMinutes(value).TotalMinutes},
                {"МинутыСекунды", (value) =>  TimeSpan.FromMinutes(value).TotalSeconds},
                {"МинутыМилисекунды", (value) =>  TimeSpan.FromMinutes(value).TotalMilliseconds},

                {"СекундыЧасы", (value) =>  TimeSpan.FromSeconds(value).TotalHours},
                {"СекундыМинуты", (value) =>  TimeSpan.FromSeconds(value).TotalMinutes},
                {"СекундыСекунды", (value) =>  TimeSpan.FromSeconds(value).TotalSeconds},
                {"СекундыМилисекунды", (value) =>  TimeSpan.FromSeconds(value).TotalMilliseconds},

                {"МилисекундыЧасы", (value) =>  TimeSpan.FromMilliseconds(value).TotalHours},
                {"МилисекундыМинуты", (value) =>  TimeSpan.FromMilliseconds(value).TotalMinutes},
                {"МилисекундыСекунды", (value) =>  TimeSpan.FromMilliseconds(value).TotalSeconds},
                {"МилисекундыМилисекунды", (value) =>  TimeSpan.FromMilliseconds(value).TotalMilliseconds}
            };
        }

        public double GetTime() => convertMetols[_metod](_value);
    }
}
