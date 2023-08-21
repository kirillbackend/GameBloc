using GameBloc.Models.Entity;
using GameBloc.Models.Setvices.Game.Interface;

namespace GameBloc.Models.Setvices.Game
{
    public class SearchGameService : ISearchGameService
    {
        private  IGame _game;

        public SearchGameService()
        {
        }

        public IGame GetGame(int id)
        {
            using (var context = new ApplicationContext())
            {
                _game = context.Games.FirstOrDefault(i => i.Id == id);
            }
            return _game;
        }
    }
}
