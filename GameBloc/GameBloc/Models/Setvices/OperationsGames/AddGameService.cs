using GameBloc.Models.Entity;
using GameBloc.Models.Setvices.OperationsGames.Interface;

namespace GameBloc.Models.Setvices.OperationsGames
{
    public class AddGameService : IAddGameService
    {
        public void AddGame(Game game)
        {
            using (var context = new ApplicationContext())
            {
                context.Games.Add(game);
                context.SaveChanges();
            }
        }
    }
}
