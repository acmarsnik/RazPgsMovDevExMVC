using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    public class RpMovieDECustMethodModel : PageModel
    {
        private readonly MovieContext _context;

        public RpMovieDECustMethodModel(MovieContext context)
        {
            _context = context;
        }

        public static List<DrawFromAbmc> abmcList = new List<DrawFromAbmc>();
        public static string jsonAbmc;
        public IList<Movie> Movie { get; set; }
        const string ValidationErrorMessage = "The record cannot be saved due to a validation error";
        public static List<Movie> movies { get; set; } = new List<Movie>();

        

        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public async Task OnGetAsync()
        {

            var movies = from m in _context.Movie
                         select m;

            Movie = await movies.ToListAsync();


        }

        public Microsoft.AspNetCore.Mvc.ActionResult GetMovies(DataSourceLoadOptions loadOptions)
        {
            var result = DataSourceLoader.Load(movies, loadOptions);
            var resultJson = JsonConvert.SerializeObject(result);
            return Content(resultJson, "application/json");
        }

        public object GetMovies2(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_context.Movie, loadOptions);
        }

        // Inserting a new item into the "Movie" collection
        public System.Web.Mvc.ActionResult InsertMovie(string values)
        {
            var newMovie = new Movie();                             // Creating a new item
            JsonConvert.PopulateObject(values, newMovie);           // Populating the item with the values
            if (!TryValidateModel(newMovie))                        // Validating the item
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ValidationErrorMessage);
            _context.Movie.Add(newMovie);                            // Adding the item to the database
            _context.SaveChanges();
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
        // Updating an item in the "Movie" collection
        public System.Web.Mvc.ActionResult UpdateMovie(int key, string values)
        {
            var movie = _context.Movie.First(m => m.ID == key); // Finding the item to be updated by key
            JsonConvert.PopulateObject(values, movie);              // Populating the found item with the changed values
            if (!TryValidateModel(movie))                           // Validating the updated item
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, ValidationErrorMessage);
            _context.SaveChanges();
            return new HttpStatusCodeResult(HttpStatusCode.Created);
        }

        // Removing an item from the "Movie" collection
        public void DeleteMovie(int key)
        {
            var movie = _context.Movie.First(m => m.ID == key); // Finding the item to be removed by key
            _context.Movie.Remove(movie);                            // Removing the found item
            _context.SaveChanges();
        }
    }
}