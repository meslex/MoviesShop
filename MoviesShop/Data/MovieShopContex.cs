using Microsoft.EntityFrameworkCore;
using System;
using MoviesShop.Models;
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

            modelBuilder.Entity<Models.Genre>().HasData(new Models.Genre
            {
                GenreId = 1,
                Title = "Comedy",
                Description = "Comedy is a genre of film in which the main emphasis is on humour." +
                " These films are designed to make the audience laugh through amusement and most often" +
                " work by exaggerating characteristics for humorous effect."
            });

            modelBuilder.Entity<Models.Genre>().HasData(new Models.Genre
            {
                GenreId = 2,
                Title = "Drama",
                Description = "In film and television, drama is a genre of narrative fiction" +
                " (or semi-fiction) intended to be more serious than humorous in tone. Drama " +
                "of this kind is usually qualified with additional terms that specify" +
                " its particular subgenre, such as police crime drama, political drama, legal drama, " +
                "historical period drama, domestic drama, or comedy - drama."
            });

            modelBuilder.Entity<Models.Movie>().HasData(new Models.Movie
            {
                MovieId = 1,
                Title = "Heathers",
                Country = "USA",
                Director = "Michael Lehman",
                GenreId = 1,
                Price = 13,
                Description = "In order to get out of the snobby clique that is destroying her good-girl" +
                " reputation, an intelligent teen teams up with a dark sociopath in a plot to kill the cool kids.",
                ProductionCompany = "New World Pictures",
                ReleaseDate = DateTime.Parse("1989-3-31")
            });

            modelBuilder.Entity<Models.Movie>().HasData(new Models.Movie
            {
                MovieId = 2,
                Title = "American Beauty",
                Country = "USA",
                Director = "Sam Mendes",
                GenreId = 2,
                Price = 35,
                Description = "A sexually frustrated suburban father has a mid-life crisis after becoming " +
                "infatuated with his daughter's best friend.",
                ProductionCompany = "DreamWorks",
                ReleaseDate = DateTime.Parse("1999-10-1")
            });

            modelBuilder.Entity<Models.Actor>().HasData(new Models.Actor
            {
                ActorId = 1,
                Firstname = "Winona",
                Surname = "Ryder",
                Birthday = DateTime.Parse("1971-10-29"),
                Country = "USA"
            });

            modelBuilder.Entity<Models.Actor>().HasData(new Models.Actor
            {
                ActorId = 2,
                Firstname = "Christian",
                Surname = "Slater",
                Birthday = DateTime.Parse("1969-8-18"),
                Country = "USA"
            });

            modelBuilder.Entity<Models.Actor>().HasData(new Models.Actor
            {
                ActorId = 3,
                Firstname = "Kevin",
                Surname = "Spacey",
                Birthday = DateTime.Parse("1959-7-26"),
                Country = "USA"
            });

            modelBuilder.Entity<Models.Actor>().HasData(new Models.Actor
            {
                ActorId = 4,
                Firstname = "Annette",
                Surname = "Bening",
                Birthday = DateTime.Parse("1958-5-29"),
                Country = "USA"
            });

            modelBuilder.Entity<Models.MainActors>().HasData(new Models.MainActors
            {
                ActorId = 1,
                MovieId = 1,
            });

            modelBuilder.Entity<Models.MainActors>().HasData(new Models.MainActors
            {
                ActorId = 2,
                MovieId = 1,
            });

            modelBuilder.Entity<Models.MainActors>().HasData(new Models.MainActors
            {
                ActorId = 3,
                MovieId = 2,
            });

            modelBuilder.Entity<Models.MainActors>().HasData(new Models.MainActors
            {
                ActorId = 4,
                MovieId = 2,
            });

            modelBuilder.Entity<Models.Client>().HasData(new Models.Client
            {
                ClientId = 1,
                Firstname = "Oleg",
                Surname = "Volovoy",
                Country = "Ukraine",
                Birthday = DateTime.Parse("1999-4-16")
            });

        }

        public DbSet<Models.Movie> Movies { get; set; }
        public DbSet<Models.Actor> Actors { get; set; }
        public DbSet<Models.MainActors> MainActors { get; set; }
        public DbSet<Models.Genre> Genres { get; set; }
        public DbSet<Models.Client> Client { get; set; }
    }
}
