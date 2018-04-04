using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.DataGrids
{
    public class RpAbmcDEFlatDGController : Controller
    {
        public ActionResult RpAbmcDEFlatDG()
            
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://www.jasonbase.com/things/jWne.json");
                var result = JsonConvert.DeserializeObject<DrawFromAbmc>(json);
                return View(result);
            }

        }
    }
}