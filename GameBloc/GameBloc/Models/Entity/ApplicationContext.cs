using Microsoft.EntityFrameworkCore;

namespace GameBloc.Models.Entity
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Database=GameBlocDB;Username=postgres;Password=1234567");
        }
    }
}
