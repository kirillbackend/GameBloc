namespace GameBloc.Models.Setvices.PrintName.Interface
{
    public interface IPrint
    {
        public string Name { set; }
        public string PrintName();
    }
}