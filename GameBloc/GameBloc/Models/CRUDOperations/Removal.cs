using GameBloc.Models.Entity;

namespace GameBloc.Models.CRUDOperations
{
    public class Removal : IOpiration
    {
        private readonly int _id;

        public Removal(int id)
        {
            _id = id;
        }

        public void PerformOperation()
        {
            using (var delete = new ApplicationContext())
            {
                Game? game = delete.Games.FirstOrDefault(g => g.Id == _id);
                if (game != null)
                {
                    delete.Games.Remove(game);
                    delete.SaveChanges();
                }
            }
        }
    }
}
