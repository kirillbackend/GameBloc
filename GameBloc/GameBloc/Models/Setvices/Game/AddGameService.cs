using GameBloc.Models.Entity;
using GameBloc.Models.Setvices.Game.Interface;

namespace GameBloc.Models.Setvices.Game
{
    public class AddGameService : IAddGameService
    {
        public void AddGame(IGame game)
        {
            using (var context = new ApplicationContext())
            {
                context.Games.Add((Entity.Game)game);
                context.SaveChanges();
            }
        }
    }
}
