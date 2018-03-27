
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using System.Net;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace RazorPagesMovie.Pages.Movies
{
    public class IndexDEController : Microsoft.AspNetCore.Mvc.Controller
    {
        //private readonly RazorPagesMovie.Models.MovieContext _context;

        //public IndexDEController(RazorPagesMovie.Models.MovieContext context)
        //{
        //    _context = context;
        //}

        //public IList<Movie> Movie { get; set; }
        //const string ValidationErrorMessage = "The record cannot be saved due to a validation error";

        //// Requires using Microsoft.AspNetCore.Mvc.Rendering;
        //public async Task OnGetAsync()
        //{

        //    var movies = from m in _context.Movie
        //                 select m;

        //    Movie = await movies.ToListAsync();
        //}
        // Fetching items from the "Movie" collection
        public static List<Movie> movies { get; set; } = new List<Movie> {
new Movie() { ID = 1, Title = "The Shawshank Redemption" , Genre="Drama", Price=7.43M, Rating = "R", ReleaseDate = new DateTime(1994, 10, 14)},
new Movie() { ID = 2, Title = "The Godfather" , Genre="Crime", Price=6.52M, Rating = "R", ReleaseDate = new DateTime(1972, 03, 24) },
new Movie() { ID = 3, Title = "The Godfather: Part II" , Genre="Drama", Price=4.98M, Rating = "R", ReleaseDate = new DateTime(1974, 12, 20)  },
new Movie() { ID = 4, Title = "The Dark Knight" , Genre="Action", Price=8.12M, Rating = "PG-13", ReleaseDate = new DateTime(2008, 07, 18) },
new Movie() { ID = 5, Title = "12 Angry Men" , Genre="Crime", Price=9.27M, Rating = "Approved", ReleaseDate = new DateTime(1957, 04, 01)  },
new Movie() { ID = 6, Title = "Schindler's List" , Genre="Biography", Price=5.90M, Rating = "R", ReleaseDate = new DateTime(1994, 02, 04)  },
new Movie() { ID = 7, Title = "The Lord of the Rings: The Return of the King" , Genre="Adventure", Price=3.68M, Rating = "PG-13", ReleaseDate = new DateTime(2003, 12, 17)  }
        };

        public Microsoft.AspNetCore.Mvc.ActionResult GetMovies(DataSourceLoadOptions loadOptions)
        {
            var result = DataSourceLoader.Load(movies, loadOptions);
            var resultJson = JsonConvert.SerializeObject(result);
            return Content(resultJson, "application/json");
        }

        //// Inserting a new item into the "Movie" collection
        //public ActionResult InsertMovie(string values)
        //{
        //    var newMovie = new Movie();                             // Creating a new item
        //    JsonConvert.PopulateObject(values, newMovie);           // Populating the item with the values
        //    if (!TryValidateModel(newMovie))                        // Validating the item
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ValidationErrorMessage);
        //    _context.Movie.Add(newMovie);                            // Adding the item to the database
        //    _context.SaveChanges();
        //    return new HttpStatusCodeResult(HttpStatusCode.OK);
        //}
        //// Updating an item in the "Movie" collection
        //public ActionResult UpdateMovie(int key, string values)
        //{
        //    var movie = _context.Movie.First(m => m.ID == key); // Finding the item to be updated by key
        //    JsonConvert.PopulateObject(values, movie);              // Populating the found item with the changed values
        //    if (!TryValidateModel(movie))                           // Validating the updated item
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ValidationErrorMessage);
        //    _context.SaveChanges();
        //    return new HttpStatusCodeResult(HttpStatusCode.Created);
        //}

        //// Removing an item from the "Movie" collection
        //public void DeleteMovie(int key)
        //{
        //    var movie = _context.Movie.First(m => m.ID == key); // Finding the item to be removed by key
        //    _context.Movie.Remove(movie);                            // Removing the found item
        //    _context.SaveChanges();
        //}
    }
}