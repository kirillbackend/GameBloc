using GameBloc.Models.Entity;


namespace GameBloc.Models.Setvices.OperationsGames
{
    public class AllGame : IAllGame
    {
        private  List<Game> _games;

        public AllGame()
        {
            _games = new List<Game>();
        }

        private void ReceiveGames()
        {
            using (var context = new ApplicationContext())
            {
                _games = context.Games.ToList();
            }
        }

        public List<Game> GetAllGame()
        {
            ReceiveGames();
            return _games;
        }

    }
}
