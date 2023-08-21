using GameBloc.Models.Setvices.PrintName.Interface;
using System.Text;

namespace GameBloc.Models.Setvices.PrintName
{
    public class Print : IPrint
    {
        private string _name;
        public string Name { set { _name = value; } }

        public string PrintName() => $"Hello {_name}";
        public string PrintName(int number) => $"Hello {_name} {number}";
        public string PrintName(bool isTrue) => $"Hello {_name} name is {isTrue}";
        public string PrintName(int number, bool isTrue)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"Hello {_name}");
            for (int i = 0; i < number; i++)
            {
                stringBuilder.Append($"{isTrue} \n");
            }
            return stringBuilder.ToString();
        }


    }
}
