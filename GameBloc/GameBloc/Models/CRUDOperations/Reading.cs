using GameBloc.Models.Entity;

namespace GameBloc.Models.CRUDOperations
{
    public class Reading : IOpiration
    {
        private List<Game> _game;

        public Reading()
        {
            _game = new List<Game>();
        }

        public void PerformOperation()
        {
            using (var read = new ApplicationContext())
            {
                _game = read.Games.ToList();
            }
        }

        public List<Game> Receive()
        {
            PerformOperation();
            return _game;
        }
    }
}
