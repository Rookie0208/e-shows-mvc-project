using e_shows.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_shows.Controllers
{
    public class MovieController : Controller
    {
        private readonly eshowsContext context;

        public MovieController(eshowsContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var movies = await context.Movie.ToListAsync();
            return View(movies);
        }
    }
}
