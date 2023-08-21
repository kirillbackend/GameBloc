using GameBloc.Models.Entity;

namespace GameBloc.Models.Setvices.Game.Interface
{
    public interface ISearchGameService
    {
        public IGame GetGame(int id);
    }
}