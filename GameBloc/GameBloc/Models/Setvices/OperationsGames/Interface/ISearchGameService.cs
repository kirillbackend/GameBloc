using GameBloc.Models.Entity;

namespace GameBloc.Models.Setvices.OperationsGames.Interface
{
    public interface ISearchGameService
    {
        public Game GetGame(int id);
    }
}