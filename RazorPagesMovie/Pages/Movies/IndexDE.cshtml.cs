
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

        public List<Movie> movies = new List<Movie>
        {
            new Movie(){ ID = 1, Title="Title1" },
            new Movie(){ ID = 2, Title="Title2" },
            new Movie(){ ID = 3, Title="Title3" },
            new Movie(){ ID = 4, Title="Title4" }
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