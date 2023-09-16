using GameBloc.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameBloc.Data
{
    public class ApplicationContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("GameBlocMVC"));
        }
    }
}
