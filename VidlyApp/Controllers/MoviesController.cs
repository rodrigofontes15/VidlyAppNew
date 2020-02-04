using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Movies
      
        public ActionResult Movies()
        {

            var movie = new List<Movie>
            {
                new Movie { Name = "Blade", Id=1},
                new Movie { Name = "Corvo", Id=2}
            };
 

            var viewModel = new RandomMovieViewModel
            {
                Movies = movie
               
            };

            return View(viewModel);
        }
       
    }
        
}