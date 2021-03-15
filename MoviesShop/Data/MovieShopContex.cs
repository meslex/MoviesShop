using Microsoft.EntityFrameworkCore;

namespace MoviesShop.Data
{
    public class MovieShopContex : DbContext
    {
        public MovieShopContex(DbContextOptions<MovieShopContex> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.MainActors>().HasKey(ma => new { ma.ActorId, ma.MovieId });
        }

        public DbSet<Models.Movie> Movies { get; set; }
        public DbSet<Models.Actor> Actors { get; set; }
        public DbSet<Models.MainActors> MainActors { get; set; }
        public DbSet<Models.Genre> Genres { get; set; }
    }
}
