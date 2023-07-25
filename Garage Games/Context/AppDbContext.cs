using Garage_Games.Models;
using Microsoft.EntityFrameworkCore;

namespace Garage_Games.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {    
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<VideoGame> VideoGames { get; set; }

    }
}
