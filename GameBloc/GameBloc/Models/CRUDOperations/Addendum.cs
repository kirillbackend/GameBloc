using GameBloc.Models.Entity;

namespace GameBloc.Models.CRUDOperations
{
    public class Addendum : IOpiration
    {
        private readonly Game _game;

        public Addendum(Game game)
        {
            _game = game;
        }

        public void PerformOperation()
        {
            using (var add = new ApplicationContext())
            {
                add.Games.Add(_game);
                add.SaveChanges();
            }
        }
    }
}
