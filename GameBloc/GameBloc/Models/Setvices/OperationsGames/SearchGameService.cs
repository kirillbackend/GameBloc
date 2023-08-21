using GameBloc.Models.Entity;
using GameBloc.Models.Setvices.OperationsGames.Interface;

namespace GameBloc.Models.Setvices.OperationsGames
{
    public class SearchGameService : ISearchGameService
    {
        private  Game _game;

        public SearchGameService()
        {
        }

        private void ReceiveGames(int id)
        {
            using (var context = new ApplicationContext())
            {
                _game = context.Games.FirstOrDefault(i => i.Id == id);
            }
        }

        public Game GetGame(int id)
        {
            ReceiveGames(id);
            return _game;
        }
    }
}
