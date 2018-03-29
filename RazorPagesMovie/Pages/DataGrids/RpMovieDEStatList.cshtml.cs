
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
using System.Data;
using System.Xml;

namespace RazorPagesMovie.Pages.Movies
{
    public class IndexDEController : Microsoft.AspNetCore.Mvc.Controller
    {
        //Creating Static List of Movies
        public static List<Movie> movies { get; set; } = new List<Movie> {
            new Movie() { ID = 1, Title = "The Shawshank Redemption" , Genre="Drama", Price=7.43M, Rating = "R", ReleaseDate = new DateTime(1994, 10, 14)},
            new Movie() { ID = 2, Title = "The Godfather" , Genre="Crime", Price=6.52M, Rating = "R", ReleaseDate = new DateTime(1972, 03, 24) },
            new Movie() { ID = 3, Title = "The Godfather: Part II" , Genre="Drama", Price=4.98M, Rating = "R", ReleaseDate = new DateTime(1974, 12, 20)  },
            new Movie() { ID = 4, Title = "The Dark Knight" , Genre="Action", Price=8.12M, Rating = "PG-13", ReleaseDate = new DateTime(2008, 07, 18) },
            new Movie() { ID = 5, Title = "12 Angry Men" , Genre="Crime", Price=9.27M, Rating = "Approved", ReleaseDate = new DateTime(1957, 04, 01)  },
            new Movie() { ID = 6, Title = "Schindler's List" , Genre="Biography", Price=5.90M, Rating = "R", ReleaseDate = new DateTime(1994, 02, 04)  },
            new Movie() { ID = 7, Title = "The Lord of the Rings: The Return of the King" , Genre="Adventure", Price=3.68M, Rating = "PG-13", ReleaseDate = new DateTime(2003, 12, 17)  }
        };
    }
}