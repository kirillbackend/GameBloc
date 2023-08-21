using GameBloc.Models.Entity;


namespace GameBloc.Models.Setvices.Game
{
    public class AllGame : IAllGame
    {
        private  List<Entity.Game> _games;

        public AllGame()
        {
            _games = new List<Entity.Game>();
            ReceiveGames();
        }

        private void ReceiveGames()
        {
            using (var context = new ApplicationContext())
            {
                _games = context.Games.ToList();
            }
        }

        public List<Entity.Game> GetAllGame() => _games;
    }
}
