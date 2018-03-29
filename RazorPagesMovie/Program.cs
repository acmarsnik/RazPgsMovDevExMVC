// Unused usings removed.
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RazorPagesMovie.Models;
using RazorPagesMovie.Pages.Movies;
using System;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<MovieContext>();
                    // requires using Microsoft.EntityFrameworkCore;
                    context.Database.Migrate();
                    // Requires using RazorPagesMovie.Models;
                    SeedData.Initialize(services);
                    
                    //Print all info about Movies in DB
                    //foreach (Movie m in context.Movie)
                    //{
                    //    Console.WriteLine(' ');
                    //    Console.WriteLine("**********************************************************************************************************************************************************");
                    //    Console.WriteLine(' ');
                    //    Console.WriteLine("ID: " + m.ID.ToString());
                    //    Console.WriteLine("Title: " + m.Title.ToString());
                    //    Console.WriteLine("Release Date: " + m.ReleaseDate.ToString());
                    //    Console.WriteLine("Price: " + m.Price.ToString());
                    //    Console.WriteLine("Genre: " + m.Genre.ToString());
                    //    Console.WriteLine("Rating: " + m.Rating.ToString());
                    //    Console.WriteLine(' ');
                    //    Console.WriteLine("**********************************************************************************************************************************************************");
                    //    Console.WriteLine(' ');
                    //}
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
