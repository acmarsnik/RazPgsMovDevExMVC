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
            using (System.IO.StreamReader r = new System.IO.StreamReader("C:/Users/amarsni/source/repos/RazPgsMovDevExMVC/RazorPagesMovie/Pages/Movies/DrawFromAbmc_e94058_1.json"))
            {
                IndexDEController.jsonAbmc = r.ReadToEnd();

            }

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
                    foreach(Movie m in context.Movie)
                    {
                        Console.WriteLine(' ');
                        Console.WriteLine("**********************************************************************************************************************************************************");
                        Console.WriteLine(' ');
                        Console.WriteLine(m.ID.ToString());
                        Console.WriteLine(m.Price.ToString());
                        Console.WriteLine(m.Rating.ToString());
                        Console.WriteLine(m.ReleaseDate.ToString());
                        Console.WriteLine(m.Title.ToString());
                        Console.WriteLine(' ');
                        Console.WriteLine("**********************************************************************************************************************************************************");
                        Console.WriteLine(' ');
                    }
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
