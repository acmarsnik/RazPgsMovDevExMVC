using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        ReleaseDate = DateTime.Parse("1994-10-14"),
                        Genre = "Drama",
                        Price = 17.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "The Godfather",
                        ReleaseDate = DateTime.Parse("1972-3-24"),
                        Genre = "Crime",
                        Price = 16.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "The Godfather: Part II",
                        ReleaseDate = DateTime.Parse("1974-12-20"),
                        Genre = "Drama",
                        Price = 16.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "The Dark Knight",
                        ReleaseDate = DateTime.Parse("2008-7-18"),
                        Genre = "Action",
                        Price = 12.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "12 Angry Men",
                        ReleaseDate = DateTime.Parse("1957-04-01"),
                        Genre = "Crime",
                        Price = 13.99M,
                        Rating = "Approved"
                    },

                    new Movie
                    {
                        Title = "Schindler's List",
                        ReleaseDate = DateTime.Parse("1994-02-04"),
                        Genre = "Biography",
                        Price = 12.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "The Lord of the Rings: The Return of the King",
                        ReleaseDate = DateTime.Parse("2003-12-17"),
                        Genre = "Adventure",
                        Price = 12.99M,
                        Rating = "PG-13"
                    }
                    // New Movie Template, Uncomment and Fill in Values
                    //,

                    //new Movie
                    //{
                    //    Title = "T",
                    //    ReleaseDate = DateTime.Parse("2000-01-01"),
                    //    Genre = "G",
                    //    Price = 00.00M,
                    //    Rating = "R"
                    //}
                );
                context.SaveChanges();
            }
        }
    }
}

// Seed Data Matching List in IndexDE
//new Movie() { ID = 1, Title = "The Shawshank Redemption", Genre = "Drama", Price = 7.43M, Rating = "R", ReleaseDate = new DateTime(1994, 10, 14)},
//new Movie() { ID = 2, Title = "The Godfather" , Genre = "Crime", Price = 6.52M, Rating = "R", ReleaseDate = new DateTime(1972, 03, 24) },
//new Movie() { ID = 3, Title = "The Godfather: Part II" , Genre = "Drama", Price = 4.98M, Rating = "R", ReleaseDate = new DateTime(1974, 12, 20)  },
//new Movie() { ID = 4, Title = "The Dark Knight" , Genre = "Action", Price = 8.12M, Rating = "PG-13", ReleaseDate = new DateTime(2008, 07, 18) },
//new Movie() { ID = 5, Title = "12 Angry Men" , Genre = "Crime", Price = 9.27M, Rating = "Approved", ReleaseDate = new DateTime(1957, 04, 01)  },
//new Movie() { ID = 6, Title = "Schindler's List" , Genre = "Biography", Price = 5.90M, Rating = "R", ReleaseDate = new DateTime(1994, 02, 04)  },
//new Movie() {ID = 7, Title = "The Lord of the Rings: The Return of the King" , Genre = "Adventure", Price = 3.68M, Rating = "PG-13", ReleaseDate = new DateTime(2003, 12, 17) }
//new Movie() {ID = 0, Title = "T" , Genre = "G", Price = 00.00M, Rating = "R", ReleaseDate = new DateTime(2000, 01, 01) }

// Old Seed Data
//new Movie
//{
//    Title = "When Harry Met Sally",
//    ReleaseDate = DateTime.Parse("1989-2-12"),
//    Genre = "Romantic Comedy",
//    Price = 7.99M,
//    Rating = "R"
//},

//            new Movie
//            {
//                Title = "Ghostbusters",
//                ReleaseDate = DateTime.Parse("1984-3-13"),
//                Genre = "Comedy",
//                Price = 8.99M,
//                Rating = "G"
//            },

//            new Movie
//            {
//                Title = "Ghostbusters 2",
//                ReleaseDate = DateTime.Parse("1986-2-23"),
//                Genre = "Comedy",
//                Price = 9.99M,
//                Rating = "PG"
//            },

//            new Movie
//            {
//                Title = "Rio Bravo",
//                ReleaseDate = DateTime.Parse("1959-4-15"),
//                Genre = "Western",
//                Price = 3.99M,
//                Rating = "PG-13"
//            }